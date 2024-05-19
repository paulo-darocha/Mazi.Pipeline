using Mazi.Pipeline.Api.Security;
using Mazi.Pipeline.WebUi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Mazi.Pipeline.WebUi.Controllers;

[AllowAnonymous]
public class SecurityController(ISecurityConfiguration securityConfiguration)
   : Controller
{
   private ISecurityConfiguration securityConfiguration =
      securityConfiguration
      ?? throw new ArgumentNullException(
         nameof(securityConfiguration),
         $"mz_SecurityController: {nameof(securityConfiguration)} is null."
      );

   public IActionResult Login()
   {
      var model = new SecurityLoginModel();

      if (securityConfiguration.DevelopmentMode == true)
      {
         AddLoginTypeKeyValue(
            model,
            "Local Development",
            GetUrlForDevelopmentLogin(),
            null
         );
      }

      return View(model);
   }

   public IActionResult DevelopmentLogin()
   {
      if (securityConfiguration.DevelopmentMode == false)
         return NotFound();
      else
      {
         var model = new DevelopmentLoginModel();
         var redirectUrl = GetPostActionRedirectUri();
         if (redirectUrl != "/")
            model.RedirectUrl = redirectUrl;
         return View();
      }
   }

   [HttpPost]
   public async Task<IActionResult> DevelopmentLogin(DevelopmentLoginModel model)
   {
      if (securityConfiguration.DevelopmentMode == false)
         return NotFound();
      else
      {
         var claims = new List<Claim>
         {
            new(
               SecurityConstants.Claim_X_MsClientPrincipalId,
               Guid.NewGuid().ToString()
            ),
            new(
               SecurityConstants.Claim_X_MsClientPrincipalIdp,
               SecurityConstants.Idp_DevelopmentMode
            ),
            new(SecurityConstants.Claim_X_MsClientPrincipalName, model.Username)
         };

         var temp = new ClaimsPrincipal(
            new ClaimsIdentity(
               claims,
               CookieAuthenticationDefaults.AuthenticationScheme
            )
         );

         await HttpContext.SignInAsync(
            temp,
            new AuthenticationProperties
            {
               IsPersistent = model.KeepMeLoggedIn,
               AllowRefresh = true
            }
         );

         if (model.RedirectUrl != null)
            return Redirect(model.RedirectUrl);
         else
            return Redirect(securityConfiguration.PostLoginPath);
      }
   }

   // private methods ////////////////////////////////////////
   // private methods ////////////////////////////////////////

   private void AddLoginTypeKeyValue(
      SecurityLoginModel model,
      string key,
      string value,
      string logoUrl
   )
   {
      model.LoginTypes ??= new();

      model.LoginTypes.Add(
         new SecurityLoginOption()
         {
            Key = key,
            Value = value,
            LogoFilename = logoUrl
         }
      );
   }

   private string GetUrlForDevelopmentLogin()
   {
      if (Request != null && Request.Query.ContainsKey("ReturnUrl") == true)
      {
         return Url.Action(
            "DevelopmentLogin",
            new { ReturnUrl = Request.Query["ReturnUrl"] }
         );
      }
      else
      {
         return Url.Action("DevelopmentLogin");
      }
   }

   private string GetPostActionRedirectUri()
   {
      if (Request.Query.ContainsKey("ReturnUrl") == false)
         return "/";
      else
         return Request.Query["ReturnUrl"];
   }
}
