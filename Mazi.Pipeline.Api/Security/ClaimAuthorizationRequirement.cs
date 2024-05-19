using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.Security;

public class ClaimAuthorizationRequirement : IAuthorizationRequirement
{
	public List<string> Roles { get; set; } = [];
	public List<string> PermissionNames { get; set; } = [];
}
