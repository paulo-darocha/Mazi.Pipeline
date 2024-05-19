using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Common;
using Mazi.Pipeline.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public partial class SqlEntityFrameworkPersonRepository
   : SqlEntityFrameworkSearchableRepositoryBase<PersonEntity, MaziAppDbContext>,
      IPersonRepository
{
   public SqlEntityFrameworkPersonRepository(MaziAppDbContext context)
      : base(context) { }

   protected override DbSet<PersonEntity> EntityDbSet => Context.PersonEntities;

   protected override Expression<Func<PersonEntity, bool>> GetPredicateForContains(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<
      Func<PersonEntity, bool>
   > GetPredicateForDoesNotContain(SearchArgument arg)
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<PersonEntity, bool>> GetPredicateForStartsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<PersonEntity, bool>> GetPredicateForEndsWith(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<PersonEntity, bool>> GetPredicateForEquals(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override Expression<Func<PersonEntity, bool>> GetPredicateForIsNotEqualTo(
      SearchArgument arg
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<PersonEntity> AddSortAscending(
      IOrderedQueryable<PersonEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }

   protected override IOrderedQueryable<PersonEntity> AddSortDescending(
      IOrderedQueryable<PersonEntity> query,
      string propertyName,
      bool isFirstSort
   )
   {
      throw new NotImplementedException();
   }
}
