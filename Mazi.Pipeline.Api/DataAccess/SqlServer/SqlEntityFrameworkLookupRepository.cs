using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Common;
using Mazi.Pipeline.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public partial class SqlEntityFrameworkLookupRepository
   : SqlEntityFrameworkSearchableRepositoryBase<LookupEntity, MaziAppDbContext>,
      ILookupRepository
{
   public SqlEntityFrameworkLookupRepository(MaziAppDbContext context)
      : base(context) { }

   public virtual IList<LookupEntity> GetAllByType(string lookupType)
   {
      throw new NotImplementedException();
   }

   protected override DbSet<LookupEntity> EntityDbSet => Context.LookupEntities;

   protected override Expression<Func<LookupEntity, bool>> GetPredicateForContains(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<LookupEntity, bool>
   > GetPredicateForDoesNotContain(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<LookupEntity, bool>> GetPredicateForStartsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<LookupEntity, bool>> GetPredicateForEndsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<LookupEntity, bool>> GetPredicateForEquals(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<LookupEntity, bool>> GetPredicateForIsNotEqualTo(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<LookupEntity> AddSortAscending(
      IOrderedQueryable<LookupEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<LookupEntity> AddSortDescending(
      IOrderedQueryable<LookupEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }
}
