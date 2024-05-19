using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Mazi.Pipeline.Api.Security;

public class HttpContextClaimsAccessor(IHttpContextAccessor accessor) : IClaimsAccessor
{
   private IEnumerable<Claim> claims;
   private HttpContext httpContext;

   private HttpContext Context
   {
      get
      {
         if (httpContext == null)
            if (accessor != null)
               httpContext = accessor.HttpContext;
         return httpContext;
      }
   }

   public IEnumerable<Claim> Claims
   {
      get
      {
         if (claims == null)
            if (Context == null || Context.User == null || Context.User.Claims == null)
               claims = new List<Claim>();
            else
               claims = Context.User.Claims.ToList();
         return claims;
      }
   }
}
