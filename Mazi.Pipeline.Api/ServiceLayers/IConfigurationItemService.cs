using Mazi.Pipeline.Common;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial interface IConfigurationItemService : IServiceLayer<ConfigurationItem>
{
   IList<ConfigurationItem> Search(
      SearchMethod searchTypeCategory = SearchMethod.Contains,
      string searchValueCategory = null,
      SearchMethod searchTypeConfigurationKey = SearchMethod.Contains,
      string searchValueConfigurationKey = null,
      SearchMethod searchTypeDescription = SearchMethod.Contains,
      string searchValueDescription = null,
      SearchMethod searchTypeConfigurationValue = SearchMethod.Contains,
      string searchValueConfigurationValue = null,
      SearchMethod searchTypeStatus = SearchMethod.Contains,
      string searchValueStatus = null,
      SearchMethod searchTypeCreatedBy = SearchMethod.Contains,
      string searchValueCreatedBy = null,
      SearchMethod searchTypeLastModifiedBy = SearchMethod.Contains,
      string searchValueLastModifiedBy = null,
      string sortBy = null,
      string sortByDirection = null,
      int maxNumberOfResults = 100
   );

   IList<ConfigurationItem> SimpleSearch(
      string searchValue,
      string sortBy = null,
      string sortByDirection = null,
      int maxNumberOfResults = 100
   );
}
