using Mazi.Pipeline.Api.Adapters;
using Mazi.Pipeline.Api.DataAccess.SqlServer;
using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;
using System;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial class LookupService
   : CoreFieldsServiceLayerBase<Lookup>,
      ILookupService
{
   public LookupService(
      ILookupRepository repository,
      IValidatorStrategy<Lookup> validator,
      IUsernameProvider usernameProvider,
      ISearchStringParserStrategy searchStringParser
   )
      : base(usernameProvider)
   {
      _Repository = repository;
      _ValidatorInstance = validator;
      _SearchStringParser = searchStringParser;

      _Adapter = new LookupAdapter();
   }

   private ILookupRepository _Repository;
   private LookupAdapter _Adapter;
   private IValidatorStrategy<Lookup> _ValidatorInstance;
   private ISearchStringParserStrategy _SearchStringParser;

   public IList<Lookup> GetAll(int maxNumberOfResults = 100)
   {
      throw new NotImplementedException();
   }

   public Lookup GetById(int id)
   {
      throw new NotImplementedException();
   }

   public void Save(Lookup saveThis)
   {
      throw new NotImplementedException();
   }

   public void DeleteById(int id)
   {
      throw new NotImplementedException();
   }

   public IList<Lookup> SimpleSearch(
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

   public IList<Lookup> Search(
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
   )
   {
      throw new NotImplementedException();
   }

   public IList<Lookup> Search(Search search)
   {
      throw new NotImplementedException();
   }

   public IList<Lookup> GetAllByType(string lookupType)
   {
      throw new NotImplementedException();
   }
}
