using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.SqlServer;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public interface ILookupRepository : ISearchableRepository<LookupEntity>
{
   IList<LookupEntity> GetAllByType(string lookupType);
}
