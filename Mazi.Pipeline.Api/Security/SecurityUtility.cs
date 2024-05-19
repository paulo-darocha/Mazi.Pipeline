using System;
using System.Security.Claims;
using System.Security.Principal;

namespace Mazi.Pipeline.Api.Security;

public class SecurityUtility
{
   private readonly ClaimsIdentity _identity;
   private readonly IPrincipal _principal;

   public SecurityUtility(IIdentity identity, IPrincipal principal)
   {
      if (identity == null)
         throw new ArgumentNullException(nameof(identity), "identity is null.");

      _identity = identity as ClaimsIdentity;
      _principal =
         principal
         ?? throw new ArgumentNullException(nameof(principal), "principal is null.");
   }

   public bool IsInRole(string role)
   {
      if (_principal is null)
         return false;
      else
         return _principal.IsInRole(role);
   }

   public bool IsAuthorized(
      string permissionName,
      int id,
      bool checkForAdminRole = true
   )
   {
      throw new NotImplementedException();
   }

   public bool IsAuthorized(string permissionName, string id, bool checkForAdminRole)
   {
      throw new NotImplementedException();
   }

   public bool IsAuthorized(string roleName)
   {
      throw new NotImplementedException();
   }

   public bool HasClaim(string claimType, string claimValue)
   {
      throw new NotImplementedException();
   }

   public bool HasClaim(string claimType)
   {
      throw new NotImplementedException();
   }
}
