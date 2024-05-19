using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DomainModels;
using System;

namespace Mazi.Pipeline.Api.Adapters;

public partial class UserAdapter : AdapterBase<User, UserEntity>
{
   protected override void PerformAdapt(User fromValue, UserEntity toValue) { }

   protected override void PerformAdapt(UserEntity fromValue, User toValue) { }
}
