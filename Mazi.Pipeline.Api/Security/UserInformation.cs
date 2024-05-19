using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Mazi.Pipeline.Api.Security;

public class UserInformation(IClaimsAccessor accessor)
   : IUserInformation,
      IUsernameProvider
{
   private List<Claim> _claims;
   private readonly IClaimsAccessor _accessor =
      accessor
      ?? throw new ArgumentNullException(
         nameof(accessor),
         "mz_UserInformation.cs: Argument cannot be null."
      );

   public List<Claim> Claims
   {
      get
      {
         if (_claims == null)
         {
            _claims = _accessor.Claims.ToList();
         }

         return _claims;
      }
   }

   public bool IsLoggedIn =>
      Claims.ContainsClaim(SecurityConstants.Claim_X_MsClientPrincipalIdp);

   public string FirstName =>
      Claims.GetClaimValue(ClaimTypes.GivenName).SafeToString();

   public string LastName => Claims.GetClaimValue(ClaimTypes.Surname).SafeToString();

   public string EmailAddress =>
      Claims.GetClaimValue(ClaimTypes.Email).SafeToString();

   public bool IsAdministrator =>
      Claims.ContainsRoleClaim(SecurityConstants.RoleName_Admin);

   public int UserId
   {
      get
      {
         var temp = Claims.GetClaimValue(ApiConstants.ClaimName_UserId);

         if (string.IsNullOrEmpty(temp) == true)
         {
            return -1;
         }
         else
         {
            if (int.TryParse(temp, out var returnValue) == false)
            {
               return -1;
            }
            else
            {
               return returnValue;
            }
         }
      }
   }

   public string Username
   {
      get
      {
         var returnValue = Claims.GetClaimValue(
            SecurityConstants.Claim_X_MsClientPrincipalName
         );

         if (string.IsNullOrWhiteSpace(returnValue) == false)
         {
            return returnValue;
         }
         else
         {
            return Claims
               .GetClaimValue(ClaimTypes.Email)
               .SafeToString("(unknown username)");
         }
      }
   }

   public string Source
   {
      get
      {
         var returnValue = Claims.GetClaimValue(
            SecurityConstants.Claim_X_MsClientPrincipalIdp
         );

         if (string.IsNullOrWhiteSpace(returnValue) == false)
         {
            return returnValue;
         }
         else
         {
            return Claims
               .GetClaimValue(ClaimTypes.Email)
               .SafeToString("(unknown source)");
         }
      }
   }
}
