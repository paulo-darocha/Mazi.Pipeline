using Mazi.Pipeline.Api.DataAccess.SqlServer;
using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;
using System;
using Mazi.Pipeline.Api.Adapters;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial class ConfigurationItemService
   : CoreFieldsServiceLayerBase<ConfigurationItem>,
      IConfigurationItemService
{
   private IConfigurationItemRepository _Repository;
   private ConfigurationItemAdapter _Adapter;
   private IValidatorStrategy<ConfigurationItem> _ValidatorInstance;
   private ISearchStringParserStrategy _SearchStringParser;

   public ConfigurationItemService(
      IConfigurationItemRepository repository,
      IValidatorStrategy<ConfigurationItem> validator,
      IUsernameProvider usernameProvider,
      ISearchStringParserStrategy searchStringParser
   )
      : base(usernameProvider)
   {
      _Repository = repository;
      _ValidatorInstance = validator;
      _SearchStringParser = searchStringParser;

      _Adapter = new ConfigurationItemAdapter();
   }

   public IList<ConfigurationItem> GetAll(int maxNumberOfResults = 100)
   {
      throw new NotImplementedException();
   }

   public ConfigurationItem GetById(int id)
   {
      throw new NotImplementedException();
   }

   public void Save(ConfigurationItem saveThis)
   {
      throw new NotImplementedException();
   }

   public void DeleteById(int id)
   {
      throw new NotImplementedException();
   }

   public IList<ConfigurationItem> SimpleSearch(
      string searchValue,
      string sortBy = null,
      string sortByDirection = null,
      int maxNumberOfResults = 100
   )
   {
      throw new NotImplementedException();
   }

   private Search GetSimpleSearch(string searchValue, int maxNumberOfResults)
   {
      throw new NotImplementedException();
   }

   private void AddSimpleSearchForValue(Search search, string searchValue)
   {
      throw new NotImplementedException();
   }

   public IList<ConfigurationItem> Search(
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
   )
   {
      throw new NotImplementedException();
   }

   public IList<ConfigurationItem> Search(Search search)
   {
      throw new NotImplementedException();
   }
}
