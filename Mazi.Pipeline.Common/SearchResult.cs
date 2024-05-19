using System.Collections.Generic;

namespace Mazi.Pipeline.Common;

public class SearchResult<T>
{
   public virtual IList<T> Results { get; set; }
   public virtual Search SearchRequest { get; set; }
}
