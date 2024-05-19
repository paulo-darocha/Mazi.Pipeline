using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Common;
using Mazi.Pipeline.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public partial class SqlEntityFrameworkFeedbackRepository
   : SqlEntityFrameworkSearchableRepositoryBase<FeedbackEntity, MaziAppDbContext>,
      IFeedbackRepository
{
   public SqlEntityFrameworkFeedbackRepository(MaziAppDbContext context)
      : base(context) { }

   protected override DbSet<FeedbackEntity> EntityDbSet => Context.FeedbackEntities;

   protected override Expression<Func<FeedbackEntity, bool>> GetPredicateForContains(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<FeedbackEntity, bool>
   > GetPredicateForDoesNotContain(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<FeedbackEntity, bool>
   > GetPredicateForStartsWith(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<FeedbackEntity, bool>> GetPredicateForEndsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<FeedbackEntity, bool>> GetPredicateForEquals(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<FeedbackEntity, bool>
   > GetPredicateForIsNotEqualTo(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<FeedbackEntity> AddSortAscending(
      IOrderedQueryable<FeedbackEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<FeedbackEntity> AddSortDescending(
      IOrderedQueryable<FeedbackEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }
}
