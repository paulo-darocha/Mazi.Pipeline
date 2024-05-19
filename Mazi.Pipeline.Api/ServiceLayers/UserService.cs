using Mazi.Pipeline.Api.Adapters;
using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DataAccess.SqlServer;
using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;
using System;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial class UserService : CoreFieldsServiceLayerBase<User>, IUserService
{
   private IUserRepository _Repository;
   private UserAdapter _Adapter;
   private IValidatorStrategy<User> _ValidatorInstance;
   private ISearchStringParserStrategy _SearchStringParser;

   public UserService(
      IUserRepository repository,
      IValidatorStrategy<User> validator,
      IUsernameProvider usernameProvider,
      ISearchStringParserStrategy searchStringParser
   )
      : base(usernameProvider)
   {
      _Repository = repository;
      _ValidatorInstance = validator;
      _SearchStringParser = searchStringParser;

      _Adapter = new UserAdapter();
   }

   public IList<User> GetAll(int maxNumberOfResults = 100)
   {
      throw new NotImplementedException();
   }

   public User GetById(int id)
   {
      throw new NotImplementedException();
   }

   public void Save(User saveThis)
   {
      throw new NotImplementedException();
   }

   public void DeleteById(int id)
   {
      throw new NotImplementedException();
   }

   public IList<User> SimpleSearch(
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

   public IList<User> Search(
      SearchMethod searchTypeUsername = SearchMethod.Contains,
      string searchValueUsername = null,
      SearchMethod searchTypeSource = SearchMethod.Contains,
      string searchValueSource = null,
      SearchMethod searchTypeEmailAddress = SearchMethod.Contains,
      string searchValueEmailAddress = null,
      SearchMethod searchTypeFirstName = SearchMethod.Contains,
      string searchValueFirstName = null,
      SearchMethod searchTypeLastName = SearchMethod.Contains,
      string searchValueLastName = null,
      SearchMethod searchTypePhoneNumber = SearchMethod.Contains,
      string searchValuePhoneNumber = null,
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

   public IList<User> Search(Search search)
   {
      throw new NotImplementedException();
   }

   public User GetByUsername(string username)
   {
      throw new NotImplementedException();
   }

   private void AddClaimsFromGlobalUser(User user)
   {
      throw new NotImplementedException();
   }
}
