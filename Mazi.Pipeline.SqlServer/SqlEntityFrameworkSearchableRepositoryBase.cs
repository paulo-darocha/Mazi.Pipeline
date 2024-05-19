using Mazi.Pipeline.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Mazi.Pipeline.SqlServer;

public abstract class SqlEntityFrameworkSearchableRepositoryBase<TEntity, TDbContext>
   : SqlEntityFrameworkCrudRepositoryBase<TEntity, TDbContext>,
      ISearchableRepository<TEntity>
   where TEntity : class, IEntityBase
   where TDbContext : DbContext
{
   public SqlEntityFrameworkSearchableRepositoryBase(TDbContext context)
      : base(context) { }

   public virtual SearchResult<TEntity> Search(Search search)
   {
      throw new NotImplementedException();
   }

   protected virtual IOrderedQueryable<TEntity> EnsureIsOrderedQueryable(
      IQueryable<TEntity> query
   )
   {
      throw new NotImplementedException();
   }

   protected virtual IOrderedQueryable<TEntity> AddSort(
      IOrderedQueryable<TEntity> query,
      SortBy sort,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }

   protected abstract IOrderedQueryable<TEntity> AddSortDescending(
      IOrderedQueryable<TEntity> query,
      string propertyName,
      bool isFirstSort
   );
   protected abstract IOrderedQueryable<TEntity> AddSortAscending(
      IOrderedQueryable<TEntity> query,
      string propertyName,
      bool isFirstSort
   );

   protected virtual IQueryable<TEntity> AddSorts(
      Search search,
      IQueryable<TEntity> query
   )
   {
      throw new NotImplementedException();
   }

   private Expression<Func<TEntity, bool>> GetWhereClause(Search search)
   {
      throw new NotImplementedException();
   }

   protected virtual IQueryable<TEntity> BeforeSearch(
      IQueryable<TEntity> query,
      Search search
   )
   {
      throw new NotImplementedException();
   }

   protected abstract Expression<Func<TEntity, bool>> GetPredicateForDoesNotContain(
      SearchArgument arg
   );
   protected abstract Expression<Func<TEntity, bool>> GetPredicateForIsNotEqualTo(
      SearchArgument arg
   );
   protected abstract Expression<Func<TEntity, bool>> GetPredicateForEquals(
      SearchArgument arg
   );
   protected abstract Expression<Func<TEntity, bool>> GetPredicateForEndsWith(
      SearchArgument arg
   );
   protected abstract Expression<Func<TEntity, bool>> GetPredicateForStartsWith(
      SearchArgument arg
   );
   protected abstract Expression<Func<TEntity, bool>> GetPredicateForContains(
      SearchArgument arg
   );
}
