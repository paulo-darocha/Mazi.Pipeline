using System.Collections.Generic;
using System.Security.Claims;

namespace Mazi.Pipeline.Api.Security;

public class SimpleClaimsAccessor : IClaimsAccessor
{
   public SimpleClaimsAccessor(IEnumerable<Claim> claims)
   {
      Claims = claims;
   }

   public IEnumerable<Claim> Claims { get; private set; }
}
