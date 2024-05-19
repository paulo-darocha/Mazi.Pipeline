using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Common;
using Mazi.Pipeline.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public partial class SqlEntityFrameworkUserClaimRepository
   : SqlEntityFrameworkSearchableRepositoryBase<UserClaimEntity, MaziAppDbContext>,
      IUserClaimRepository
{
   public SqlEntityFrameworkUserClaimRepository(MaziAppDbContext context)
      : base(context) { }

   protected override DbSet<UserClaimEntity> EntityDbSet => Context.UserClaimEntities;

   protected override Expression<Func<UserClaimEntity, bool>> GetPredicateForContains(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<UserClaimEntity, bool>
   > GetPredicateForDoesNotContain(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<UserClaimEntity, bool>> GetPredicateForStartsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<UserClaimEntity, bool>> GetPredicateForEndsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<UserClaimEntity, bool>> GetPredicateForEquals(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<UserClaimEntity, bool>
   > GetPredicateForIsNotEqualTo(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<UserClaimEntity> AddSortAscending(
      IOrderedQueryable<UserClaimEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<UserClaimEntity> AddSortDescending(
      IOrderedQueryable<UserClaimEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }
}
