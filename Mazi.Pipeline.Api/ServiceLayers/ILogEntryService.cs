using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial interface ILogEntryService : IServiceLayer<LogEntry>
{
   IList<LogEntry> Search(
      SearchMethod searchTypeCategory = SearchMethod.Contains,
      string searchValueCategory = null,
      SearchMethod searchTypeLogLevel = SearchMethod.Contains,
      string searchValueLogLevel = null,
      SearchMethod searchTypeLogText = SearchMethod.Contains,
      string searchValueLogText = null,
      SearchMethod searchTypeExceptionText = SearchMethod.Contains,
      string searchValueExceptionText = null,
      SearchMethod searchTypeEventId = SearchMethod.Contains,
      string searchValueEventId = null,
      SearchMethod searchTypeState = SearchMethod.Contains,
      string searchValueState = null,
      string sortBy = null,
      string sortByDirection = null,
      int maxNumberOfResults = 100
   );

   IList<LogEntry> SimpleSearch(
      string searchValue,
      string sortBy = null,
      string sortByDirection = null,
      int maxNumberOfResults = 100
   );
}
