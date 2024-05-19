using Microsoft.AspNetCore.Authorization;
using System;

namespace Mazi.Pipeline.Api.Security;

public class RoleAuthorizationRequirement(string roleName)
   : IAuthorizationRequirement
{
   public string RoleName { get; set; } =
      roleName
      ?? throw new ArgumentNullException(
         nameof(roleName),
         "Argument cannot be null."
      );
}
