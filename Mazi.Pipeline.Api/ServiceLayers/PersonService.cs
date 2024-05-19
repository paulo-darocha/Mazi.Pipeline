using Mazi.Pipeline.Api.Adapters;
using Mazi.Pipeline.Api.DataAccess.SqlServer;
using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;
using System;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial class PersonService
   : CoreFieldsServiceLayerBase<Person>,
      IPersonService
{
   private IPersonRepository _Repository;
   private PersonAdapter _Adapter;
   private IValidatorStrategy<Person> _ValidatorInstance;
   private ISearchStringParserStrategy _SearchStringParser;

   public PersonService(
      IPersonRepository repository,
      IValidatorStrategy<Person> validator,
      IUsernameProvider usernameProvider,
      ISearchStringParserStrategy searchStringParser
   )
      : base(usernameProvider)
   {
      _Repository = repository;
      _ValidatorInstance = validator;
      _SearchStringParser = searchStringParser;

      _Adapter = new PersonAdapter();
   }

   public IList<Person> GetAll(int maxNumberOfResults = 100)
   {
      throw new NotImplementedException();
   }

   public Person GetById(int id)
   {
      throw new NotImplementedException();
   }

   public void Save(Person saveThis)
   {
      throw new NotImplementedException();
   }

   public void DeleteById(int id)
   {
      throw new NotImplementedException();
   }

   public IList<Person> SimpleSearch(
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

   public IList<Person> Search(
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
   )
   {
      throw new NotImplementedException();
   }

   public IList<Person> Search(Search search)
   {
      throw new NotImplementedException();
   }
}
