using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System;

namespace Mazi.Pipeline.SqlServer;

public abstract class SqlEntityFrameworkCrudRepositoryBase<TEntity, TDbContext>
   : SqlEntityFrameworkRepositoryBase<TEntity, TDbContext>,
      IRepository<TEntity>
   where TEntity : class, IEntityBase
   where TDbContext : DbContext
{
   public SqlEntityFrameworkCrudRepositoryBase(TDbContext context)
      : base(context) { }

   protected abstract DbSet<TEntity> EntityDbSet { get; }

   public virtual void Delete(TEntity deleteThis)
   {
      throw new NotImplementedException();
   }

   protected virtual void BeforeDelete(TEntity deleteThis)
   {
      throw new NotImplementedException();
   }

   protected virtual void AfterDelete(TEntity deleteThis)
   {
      throw new NotImplementedException();
   }

   protected virtual List<string> Includes { get; }

   public virtual IList<TEntity> GetAll()
   {
      throw new NotImplementedException();
   }

   protected virtual IQueryable<TEntity> BeforeGetAll(IQueryable<TEntity> query)
   {
      throw new NotImplementedException();
   }

   protected virtual IQueryable<TEntity> AddDefaultSort(IQueryable<TEntity> query)
   {
      throw new NotImplementedException();
   }

   public virtual IList<TEntity> GetAll(int maxNumberOfRows, bool noIncludes)
   {
      throw new NotImplementedException();
   }

   protected virtual IQueryable<TEntity> AddIncludes(IQueryable<TEntity> queryable)
   {
      throw new NotImplementedException();
   }

   public virtual TEntity GetById(int id)
   {
      throw new NotImplementedException();
   }

   [SuppressMessage("csharp", "IDE0060")]
   private IQueryable<TEntity> BeforeGetById(IQueryable<TEntity> query, int id)
   {
      throw new NotImplementedException();
   }

   public virtual void Save(TEntity saveThis)
   {
      throw new NotImplementedException();
   }

   private void AfterSaveOnDependentEntities(TEntity saveThis)
   {
      throw new NotImplementedException();
   }

   protected virtual void BeforeSaveOnDependentEntities(TEntity saveThis)
   {
      throw new NotImplementedException();
   }

   protected virtual void BeforeSave(TEntity saveThis)
   {
      throw new NotImplementedException();
   }

   protected virtual void AfterSave(TEntity saveThis)
   {
      throw new NotImplementedException();
   }
}
