using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Common;
using Mazi.Pipeline.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public partial class SqlEntityFrameworkLogEntryRepository
   : SqlEntityFrameworkSearchableRepositoryBase<LogEntryEntity, MaziAppDbContext>,
      ILogEntryRepository
{
   public SqlEntityFrameworkLogEntryRepository(MaziAppDbContext context)
      : base(context) { }

   protected override DbSet<LogEntryEntity> EntityDbSet => Context.LogEntryEntities;

   protected override IQueryable<LogEntryEntity> AddDefaultSort(
      IQueryable<LogEntryEntity> query
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<LogEntryEntity, bool>> GetPredicateForContains(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<LogEntryEntity, bool>
   > GetPredicateForDoesNotContain(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<LogEntryEntity, bool>
   > GetPredicateForStartsWith(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<LogEntryEntity, bool>> GetPredicateForEndsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<LogEntryEntity, bool>> GetPredicateForEquals(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<LogEntryEntity, bool>
   > GetPredicateForIsNotEqualTo(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<LogEntryEntity> AddSortAscending(
      IOrderedQueryable<LogEntryEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<LogEntryEntity> AddSortDescending(
      IOrderedQueryable<LogEntryEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }
}
