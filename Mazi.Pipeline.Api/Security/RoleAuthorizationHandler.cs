using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace Mazi.Pipeline.Api.Security;

public class RoleAuthorizationHandler
   : AuthorizationHandler<RoleAuthorizationRequirement>
{
   protected override Task HandleRequirementAsync(
      AuthorizationHandlerContext authContext,
      RoleAuthorizationRequirement authRequirement
   )
   {
      var utility = new SecurityUtility(authContext.User.Identity, authContext.User);
      if (utility.IsInRole(authRequirement.RoleName) == true)
         authContext.Succeed(authRequirement);
      else
         authContext.Fail();
      return Task.CompletedTask;
   }
}
