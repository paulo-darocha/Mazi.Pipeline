using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Common;
using Mazi.Pipeline.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public partial class SqlEntityFrameworkUserRepository
   : SqlEntityFrameworkSearchableRepositoryBase<UserEntity, MaziAppDbContext>,
      IUserRepository
{
   public SqlEntityFrameworkUserRepository(MaziAppDbContext context)
      : base(context) { }

   protected override IQueryable<UserEntity> AddIncludes(
      IQueryable<UserEntity> queryable
   )
   {
      throw new NotImplementedException();
   }

   protected override DbSet<UserEntity> EntityDbSet => Context.UserEntities;

   protected override Expression<Func<UserEntity, bool>> GetPredicateForContains(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<UserEntity, bool>> GetPredicateForDoesNotContain(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<UserEntity, bool>> GetPredicateForStartsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<UserEntity, bool>> GetPredicateForEndsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<UserEntity, bool>> GetPredicateForEquals(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<UserEntity, bool>> GetPredicateForIsNotEqualTo(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<UserEntity> AddSortAscending(
      IOrderedQueryable<UserEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<UserEntity> AddSortDescending(
      IOrderedQueryable<UserEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }
}
