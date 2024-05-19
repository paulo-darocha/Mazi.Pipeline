using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Mazi.Pipeline.Api.Security;

public class LoggedInUsingEasyAuthHandler
   : AuthorizationHandler<LoggedInUsingEasyAuthRequirement>
{
   protected override Task HandleRequirementAsync(
      AuthorizationHandlerContext authContext,
      LoggedInUsingEasyAuthRequirement authRequirement
   )
   {
      var identityProviderClaim = FindClaim(
         authContext,
         SecurityConstants.Claim_X_MsClientPrincipalIdp
      );

      if (identityProviderClaim == null)
         authContext.Fail();
      else
         authContext.Succeed(authRequirement);

      return Task.CompletedTask;
   }

   // private methods  //////////////////////////////////////////
   private static Claim FindClaim(
      AuthorizationHandlerContext authContext,
      string claimName
   )
   {
      var match = authContext.User.Claims
         .Where(x => x.Type == claimName)
         .FirstOrDefault();

      return match;
   }
}
