using Mazi.Pipeline.Api.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;

namespace Mazi.Pipeline.WebUi.Security;

public class HttpContextRouteDataAccessor(IHttpContextAccessor accessor)
   : IRouteDataAccessor
{
   public string GetId()
   {
      throw new NotImplementedException();
   }

   //
   // private methods

   private static string GetValue(RouteValueDictionary values, string key)
   {
      throw new NotImplementedException();
   }
}
