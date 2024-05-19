using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial interface IPersonService : IServiceLayer<Person>
{
   IList<Person> Search(
      SearchMethod searchTypeFirstName = SearchMethod.Contains,
      string searchValueFirstName = null,
      SearchMethod searchTypeLastName = SearchMethod.Contains,
      string searchValueLastName = null,
      SearchMethod searchTypePhoneNumber = SearchMethod.Contains,
      string searchValuePhoneNumber = null,
      SearchMethod searchTypeEmailAddress = SearchMethod.Contains,
      string searchValueEmailAddress = null,
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

   IList<Person> SimpleSearch(
      string searchValue,
      string sortBy = null,
      string sortByDirection = null,
      int maxNumberOfResults = 100
   );
}
