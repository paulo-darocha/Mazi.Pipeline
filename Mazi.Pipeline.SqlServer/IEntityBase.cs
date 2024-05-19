using Mazi.Pipeline.Common;
using System.Collections.Generic;

namespace Mazi.Pipeline.SqlServer;

public interface IEntityBase : IInt32Identity, IDeleteable
{
   IList<IDependentEntityCollection> GetDependentEntities();
}
