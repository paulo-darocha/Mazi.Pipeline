using Mazi.Pipeline.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public class DependentEntityCollection<T>(IList<T> entities)
   : IDependentEntityCollection
   where T : class, IEntityBase
{
   private readonly IList<T> _entities =
      entities
      ?? throw new ArgumentNullException(
         nameof(entities),
         "Argument cannot be null."
      );

   public void BeforeSave(DbContext dbContext)
   {
      throw new NotImplementedException();
   }

   private void RemoveFromDbSet(DbContext dbContext, T entity)
   {
      throw new NotImplementedException();
   }

   public void AfterSave()
   {
      throw new NotImplementedException();
   }
}
