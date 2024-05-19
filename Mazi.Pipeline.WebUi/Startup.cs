using Mazi.Pipeline.Api;
using Mazi.Pipeline.Api.AzureStorage;
using Mazi.Pipeline.Api.DataAccess;
using Mazi.Pipeline.Api.DataAccess.SqlServer;
using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Api.Logging;
using Mazi.Pipeline.Api.Security;
using Mazi.Pipeline.Api.ServiceLayers;
using Mazi.Pipeline.Common;
using Mazi.Pipeline.WebUi.Models;
using Mazi.Pipeline.WebUi.Security;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Mazi.Pipeline.WebUi;

public partial class Startup(IConfiguration configuration)
{
   public void ConfigureServices(IServiceCollection services)
   {
      services.AddOptions();

      services.AddControllersWithViews().AddRazorRuntimeCompilation();

      services.AddDatabaseDeveloperPageExceptionFilter();

      ConfigureSecurity(services);

      QueueTypeRegistration(services);

      RegisterTypesForDbContexts(services);

      RegisterTypesForAzureStorageBlobs(services);

      RegisterTypesForEmail(services);

      RegisterQueuedTypes(services);
   }

   public void Configure(
      IApplicationBuilder app,
      IWebHostEnvironment env,
      ILoggerFactory loggerFactory
   )
   {
      if (env.IsDevelopment())
      {
         app.UseDeveloperExceptionPage();
         app.UseMigrationsEndPoint();
      }
      else
      {
         app.UseExceptionHandler("/Home/Error");
         app.UseHsts();
      }

      //ConfigureLogging(app, loggerFactory);

      ConfigureHttps(app);

      app.UseStaticFiles();

      app.UseRouting();

      ConfigureSecurity(app);

      app.UseEndpoints(endpoints =>
      {
         endpoints.MapControllerRoute(
            "default",
            "{controller=Home}/{action=Index}/{id?}"
         );
      });
   }

   protected List<ITypeRegistrationItem> _QueuedTypeRegistrations = new();

   protected virtual void ConfigureSecurity(IServiceCollection services)
   {
      ConfigureAuthentication(services);
      ConfigureAuthorization(services);
   }

   protected virtual void ConfigureAuthentication(IServiceCollection services)
   {
      var config = new SecurityConfiguration(configuration);
      services
         .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
         .AddCookie(options =>
         {
            options.LoginPath = new(config.LoginPath);
            options.LogoutPath = new(config.LogoutPath);
            options.AccessDeniedPath = new(config.LoginPath);
         });
   }

   protected virtual void ConfigureAuthorization(IServiceCollection services)
   {
      QueueTypeRegistration<IAuthorizationHandler, LoggedInUsingEasyAuthHandler>(
         ServiceLifetime.Singleton
      );
      QueueTypeRegistration<IAuthorizationHandler, RoleAuthorizationHandler>(
         ServiceLifetime.Singleton
      );
      QueueTypeRegistration<IAuthorizationHandler, ClaimAuthorizationHandler>(
         ServiceLifetime.Singleton
      );
      QueueTypeRegistration<IRouteDataAccessor, HttpContextRouteDataAccessor>();

      services.AddAuthorization(options =>
      {
         options.AddPolicy(
            SecurityConstants.Policy_LoggedInUsingEasyAuth,
            policy => policy.Requirements.Add(new LoggedInUsingEasyAuthRequirement())
         );

         options.AddPolicy(
            SecurityConstants.Policy_IsAdministrator,
            policy =>
               policy.Requirements.Add(
                  new RoleAuthorizationRequirement(SecurityConstants.RoleName_Admin)
               )
         );

         options.DefaultPolicy = options.GetPolicy(
            SecurityConstants.Policy_LoggedInUsingEasyAuth
         );
      });
   }

   protected virtual void QueueTypeRegistration<TService, TImplementation>(
      ServiceLifetime instancingMode = ServiceLifetime.Transient
   )
      where TService : class
      where TImplementation : class, TService
   {
      _QueuedTypeRegistrations.Add(
         new TypeRegistrationItem<TService, TImplementation>(instancingMode)
      );
   }

   protected virtual void QueueTypeRegistration(IServiceCollection services)
   {
      BeforeQueueTypeRegistrations(services);

      QueueTypeRegistration<IHttpContextAccessor, HttpContextAccessor>();
      QueueTypeRegistration<IClaimsAccessor, HttpContextClaimsAccessor>();
      QueueTypeRegistration<IUserInformation, UserInformation>();
      QueueTypeRegistration<IUsernameProvider, UserInformation>();
      QueueTypeRegistration<
         ISearchStringParserStrategy,
         DefaultSearchStringParserStrategy
      >();
      QueueTypeRegistrationForPopulateClaimsMiddleware();
      QueueTypeRegistrationForServiceLayer();
      QueueTypeRegistrationsForValidators();
      QueueTypeRegistrationsForRepositories();

      AfterQueueTypeRegistrations(services);
   }

   partial void BeforeQueueTypeRegistrations(IServiceCollection services);

   partial void AfterQueueTypeRegistrations(IServiceCollection services);

   protected virtual void QueueTypeRegistrationForPopulateClaimsMiddleware()
   {
      QueueTypeRegistration<PopulateClaimsMiddleware>();
      QueueTypeRegistration<ISecurityConfiguration, SecurityConfiguration>();
   }

   protected virtual void QueueTypeRegistration<TService>(
      ServiceLifetime instancingMode = ServiceLifetime.Transient
   )
      where TService : class
   {
      _QueuedTypeRegistrations.Add(
         new TypeRegistrationItem<TService, TService>(instancingMode)
      );
   }

   protected virtual void QueueTypeRegistrationForServiceLayer()
   {
      QueueTypeRegistration<IConfigurationItemService, ConfigurationItemService>();
      QueueTypeRegistration<IFeedbackService, FeedbackService>();
      QueueTypeRegistration<ILogEntryService, LogEntryService>();
      QueueTypeRegistration<ILookupService, LookupService>();
      QueueTypeRegistration<IPersonService, PersonService>();
      QueueTypeRegistration<IUserService, UserService>();
      QueueTypeRegistration<IUserClaimService, UserClaimService>();
   }

   protected virtual void QueueTypeRegistrationsForValidators()
   {
      QueueTypeRegistration<
         IValidatorStrategy<ConfigurationItem>,
         DefaultValidatorStrategy<ConfigurationItem>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<ConfigurationItemEditorViewModel>,
         DefaultValidatorStrategy<ConfigurationItemEditorViewModel>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<Feedback>,
         DefaultValidatorStrategy<Feedback>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<FeedbackEditorViewModel>,
         DefaultValidatorStrategy<FeedbackEditorViewModel>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<LogEntry>,
         DefaultValidatorStrategy<LogEntry>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<LogEntryEditorViewModel>,
         DefaultValidatorStrategy<LogEntryEditorViewModel>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<Lookup>,
         DefaultValidatorStrategy<Lookup>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<LookupEditorViewModel>,
         DefaultValidatorStrategy<LookupEditorViewModel>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<Person>,
         DefaultValidatorStrategy<Person>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<PersonEditorViewModel>,
         DefaultValidatorStrategy<PersonEditorViewModel>
      >();
      QueueTypeRegistration<IValidatorStrategy<User>, DefaultValidatorStrategy<User>>();
      QueueTypeRegistration<
         IValidatorStrategy<UserEditorViewModel>,
         DefaultValidatorStrategy<UserEditorViewModel>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<UserClaim>,
         DefaultValidatorStrategy<UserClaim>
      >();
      QueueTypeRegistration<
         IValidatorStrategy<UserClaimEditorViewModel>,
         DefaultValidatorStrategy<UserClaimEditorViewModel>
      >();
   }

   protected virtual void QueueTypeRegistrationsForRepositories()
   {
      var lifetime = ServiceLifetime.Scoped;

      QueueTypeRegistration<
         IConfigurationItemRepository,
         SqlEntityFrameworkConfigurationItemRepository
      >(lifetime);
      QueueTypeRegistration<IFeedbackRepository, SqlEntityFrameworkFeedbackRepository>(
         lifetime
      );
      QueueTypeRegistration<ILogEntryRepository, SqlEntityFrameworkLogEntryRepository>(
         lifetime
      );
      QueueTypeRegistration<ILookupRepository, SqlEntityFrameworkLookupRepository>(
         lifetime
      );
      QueueTypeRegistration<IPersonRepository, SqlEntityFrameworkPersonRepository>(
         lifetime
      );
      QueueTypeRegistration<IUserRepository, SqlEntityFrameworkUserRepository>(
         lifetime
      );
      QueueTypeRegistration<
         IUserClaimRepository,
         SqlEntityFrameworkUserClaimRepository
      >(lifetime);
   }

   protected virtual void RegisterTypesForDbContexts(IServiceCollection services)
   {
      services.AddDbContext<MaziAppDbContext>(
         options => options.UseSqlServer(configuration.GetConnectionString("default"))
      );

      QueueTypeRegistration<IMaziAppDbContext, MaziAppDbContext>();
   }

   protected virtual void RegisterTypesForAzureStorageBlobs(IServiceCollection services)
   {
      // azure images
      services
         .AddOptions<AzureBlobImageStorageOptions>()
         .Configure(options =>
         {
            options.UseDevelopmentStorage = configuration.GetValue<bool>(
               "AzureStorage:UseDevelopmentStorage"
            );
            options.AccountKey = configuration.GetValue<string>(
               "AzureStorage:AccountKey"
            );
            options.AccountName = configuration.GetValue<string>(
               "AzureStorage:AccountName"
            );
            options.ContainerName = configuration.GetValue<string>(
               "AzureStorage:ContainerName"
            );
            options.ReadTokenExpirationInSeconds = configuration.GetValue<int>(
               "AzureStorage:ReadTokenExpirationInSeconds"
            );
         });

      services.AddTransient<
         IAzureBlobImageSasTokenGenerator,
         AzureBlobImageStorageHelper
      >();
   }

   protected virtual void RegisterTypesForEmail(IServiceCollection services)
   {
      services.AddTransient<IEmailService, EmailService>();

      services
         .AddOptions<EmailConfigurationOptions>()
         .Configure(options =>
         {
            options.FromEmail = configuration.GetValue<string>("Email:FromEmail");
            options.FromName = configuration.GetValue<string>("Email:FromName");
            options.SendGridApiKey = configuration.GetValue<string>(
               "Email:SendGridApiKey"
            );
         });
   }

   protected virtual void RegisterQueuedTypes(IServiceCollection services)
   {
      BeforeRegisterQueuedTypes(services);

      foreach (var item in _QueuedTypeRegistrations)
      {
         if (item.Lifetime == ServiceLifetime.Transient)
         {
            services.AddTransient(item.ServiceType, item.ImplementationType);
         }
         else if (item.Lifetime == ServiceLifetime.Scoped)
         {
            services.AddScoped(item.ServiceType, item.ImplementationType);
         }
         else if (item.Lifetime == ServiceLifetime.Singleton)
         {
            services.AddSingleton(item.ServiceType, item.ImplementationType);
         }
         else
         {
            throw new InvalidOperationException(
               $"Unsupported instancing mode '{item.Lifetime}'."
            );
         }
      }

      AfterRegisterQueuedTypes(services);
   }

   partial void BeforeRegisterQueuedTypes(IServiceCollection services);

   partial void AfterRegisterQueuedTypes(IServiceCollection services);

   protected virtual void ConfigureLogging(
      IApplicationBuilder app,
      ILoggerFactory loggerFactory
   )
   {
      BeforeConfigureLogging(app, loggerFactory);

      var config = app.ApplicationServices.GetRequiredService<IConfiguration>();
      var connectionString = config.GetConnectionString("default");

      loggerFactory.AddProvider(
         new SqlDatabaseLoggerProvider(
            new SqlDatabaseLoggerOptions()
            {
               LogLevel = LogLevel.Information,
               ConnectionString = connectionString
            }
         )
      );

      AfterConfigureLogging(app, loggerFactory);
   }

   partial void BeforeConfigureLogging(
      IApplicationBuilder app,
      ILoggerFactory loggerFactory
   );

   partial void AfterConfigureLogging(
      IApplicationBuilder app,
      ILoggerFactory loggerFactory
   );

   protected virtual void ConfigureHttps(IApplicationBuilder app)
   {
      app.UseHttpsRedirection();
   }

   protected virtual void ConfigureSecurity(IApplicationBuilder app)
   {
      app.UseAuthentication();
      app.UsePopulateClaimsMiddleware();
      app.UseAuthorization();
   }
}
