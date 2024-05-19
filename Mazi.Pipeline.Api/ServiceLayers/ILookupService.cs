using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial interface ILookupService : IServiceLayer<Lookup>
{
   public partial interface ILookupService : IServiceLayer<Lookup>
   {
      IList<Lookup> Search(
         SearchMethod searchTypeLookupType = SearchMethod.Contains,
         string searchValueLookupType = null,
         SearchMethod searchTypeLookupKey = SearchMethod.Contains,
         string searchValueLookupKey = null,
         SearchMethod searchTypeLookupValue = SearchMethod.Contains,
         string searchValueLookupValue = null,
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

      IList<Lookup> SimpleSearch(
         string searchValue,
         string sortBy = null,
         string sortByDirection = null,
         int maxNumberOfResults = 100
      );

      IList<Lookup> GetAllByType(string lookupType);
   }
}
