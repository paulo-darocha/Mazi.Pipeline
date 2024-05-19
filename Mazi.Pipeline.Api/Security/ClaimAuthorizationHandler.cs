using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;

namespace Mazi.Pipeline.Api.Security;

public class ClaimAuthorizationHandler(IRouteDataAccessor routeDataAccessor)
   : AuthorizationHandler<ClaimAuthorizationRequirement>
{
   protected override Task HandleRequirementAsync(
      AuthorizationHandlerContext authContext,
      ClaimAuthorizationRequirement authRequirement
   )
   {
      if (
         authRequirement == null
         || authRequirement.Roles == null
         || authRequirement.PermissionNames == null
         || (
            authRequirement.Roles.Count == 0
            && authRequirement.PermissionNames.Count == 0
         )
      )
      {
         authContext.Fail();
      }

      var id = routeDataAccessor.GetId();

      if (string.IsNullOrEmpty(id) == true)
      {
         authContext.Fail();
      }
      else
      {
         var utility = new SecurityUtility(
            authContext.User.Identity,
            authContext.User
         );
         var isAuthorized = CheckIsAuthorized(authRequirement, id, utility);
         if (isAuthorized == true)
            authContext.Succeed(authRequirement);
         else
            authContext.Fail();
      }
      return Task.CompletedTask;
   }

   //
   // Private Methods
   //

   private static bool CheckIsAuthorized(
      ClaimAuthorizationRequirement authRequirement,
      string id,
      SecurityUtility utility
   )
   {
      throw new NotImplementedException();
   }
}
