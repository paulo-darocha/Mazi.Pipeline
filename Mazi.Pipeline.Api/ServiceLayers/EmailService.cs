using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SendGrid.Helpers.Mail;
using SendGrid;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using System;

namespace Mazi.Pipeline.Api.ServiceLayers;

public class EmailService : IEmailService
{
   private readonly EmailConfigurationOptions _options;
   private readonly ILogger<EmailService> _logger;

   [SuppressMessage("csharp", "IDE0052")]
   private readonly IConfigurationItemService _configItemService;

   [SuppressMessage("csharp", "IDE0052")]
   private readonly IUserService _userService;

   public EmailService(
      ILogger<EmailService> logger,
      IConfigurationItemService configItemService,
      IOptionsMonitor<EmailConfigurationOptions> options,
      IUserService userService
   )
   {
      _options = options.CurrentValue;

      if (_options.SendGridApiKey == null)
      {
         throw new ArgumentNullException(
            nameof(_options.SendGridApiKey),
            "Argument cannot be null."
         );
      }

      _configItemService = configItemService;
      _logger = logger;
      _userService = userService;
   }

   public async Task SendEmail(
      string recipientEmail,
      string recipientName,
      string subject
   )
   {
      throw new NotImplementedException();
   }

   private async Task SendEmail(SendGridMessage msg, string msgDescriptionForLogging)
   {
      throw new NotImplementedException();
   }
}
