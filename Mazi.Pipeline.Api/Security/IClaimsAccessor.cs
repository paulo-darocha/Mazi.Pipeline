using System.Collections.Generic;
using System.Security.Claims;

namespace Mazi.Pipeline.Api.Security;

public interface IClaimsAccessor
{
   IEnumerable<Claim> Claims { get; }
}
