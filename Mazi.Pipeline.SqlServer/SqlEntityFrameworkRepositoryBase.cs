using Microsoft.EntityFrameworkCore;
using System;

namespace Mazi.Pipeline.SqlServer;

public abstract class SqlEntityFrameworkRepositoryBase<TEntity, TDbContext>
   : IDisposable
   where TEntity : class, IEntityBase
   where TDbContext : DbContext
{
   protected SqlEntityFrameworkRepositoryBase(TDbContext context)
   {
      _context =
         context
         ?? throw new ArgumentNullException(nameof(context), "context is null.");
   }

   public void Dispose()
   {
      Dispose(true);
      GC.SuppressFinalize(this);
   }

   private bool _isDisposed = false;

   protected virtual void Dispose(bool disposing)
   {
      if (_isDisposed)
         return;

      if (disposing)
      {
         // free managed resources
         ((IDisposable)_context).Dispose();
      }

      _isDisposed = true;
   }

   private readonly TDbContext _context;

   protected TDbContext Context => _context;

   protected void VerifyItemIsAddedOrAttachedToDbSet(
      DbSet<TEntity> dbSet,
      TEntity item
   )
   {
      if (item == null)
      {
         return;
      }
      else
      {
         if (item.Id == 0)
         {
            dbSet.Add(item);
         }
         else
         {
            var entry = _context.Entry<TEntity>(item);

            if (entry.State == EntityState.Detached)
            {
               dbSet.Attach(item);
            }

            entry.State = EntityState.Modified;
         }
      }
   }
}
