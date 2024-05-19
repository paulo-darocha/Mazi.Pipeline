using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;
using Mazi.Pipeline.SqlServer;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public partial class SqlEntityFrameworkConfigurationItemRepository
   : SqlEntityFrameworkSearchableRepositoryBase<
      ConfigurationItemEntity,
      MaziAppDbContext
   >,
      IConfigurationItemRepository
{
   public SqlEntityFrameworkConfigurationItemRepository(MaziAppDbContext context)
      : base(context) { }

   protected override DbSet<ConfigurationItemEntity> EntityDbSet =>
      Context.ConfigurationItemEntities;

   protected override Expression<
      Func<ConfigurationItemEntity, bool>
   > GetPredicateForContains(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<ConfigurationItemEntity, bool>
   > GetPredicateForDoesNotContain(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<ConfigurationItemEntity, bool>
   > GetPredicateForStartsWith(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<ConfigurationItemEntity, bool>
   > GetPredicateForEndsWith(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<ConfigurationItemEntity, bool>
   > GetPredicateForEquals(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<ConfigurationItemEntity, bool>
   > GetPredicateForIsNotEqualTo(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<ConfigurationItemEntity> AddSortAscending(
      IOrderedQueryable<ConfigurationItemEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<ConfigurationItemEntity> AddSortDescending(
      IOrderedQueryable<ConfigurationItemEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }
}
