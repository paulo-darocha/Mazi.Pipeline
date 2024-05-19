using Microsoft.EntityFrameworkCore;

namespace Mazi.Pipeline.SqlServer;

public interface IDependentEntityCollection
{
   void AfterSave();
   void BeforeSave(DbContext dbContext);
}
