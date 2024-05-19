using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DomainModels;
using System;

namespace Mazi.Pipeline.Api.Adapters;

public partial class UserClaimAdapter : AdapterBase<UserClaim, UserClaimEntity>
{
   protected override void PerformAdapt(UserClaim fromValue, UserClaimEntity toValue)
   {
      throw new NotImplementedException();
   }

   protected override void PerformAdapt(UserClaimEntity fromValue, UserClaim toValue)
   {
      throw new NotImplementedException();
   }
}
