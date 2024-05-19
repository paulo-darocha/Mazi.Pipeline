using Mazi.Pipeline.Common;

namespace Mazi.Pipeline.SqlServer;

public interface ISearchableRepository<T> : IRepository<T>
   where T : IInt32Identity
{
   SearchResult<T> Search(Search search);
}
