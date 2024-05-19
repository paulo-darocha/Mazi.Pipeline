using Mazi.Pipeline.Api.Adapters;
using Mazi.Pipeline.Api.DataAccess.SqlServer;
using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;
using System;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial class UserClaimService
   : CoreFieldsServiceLayerBase<UserClaim>,
      IUserClaimService
{
   private IUserClaimRepository _Repository;
   private UserClaimAdapter _Adapter;
   private IValidatorStrategy<UserClaim> _ValidatorInstance;
   private ISearchStringParserStrategy _SearchStringParser;

   public UserClaimService(
      IUserClaimRepository repository,
      IValidatorStrategy<UserClaim> validator,
      IUsernameProvider usernameProvider,
      ISearchStringParserStrategy searchStringParser
   )
      : base(usernameProvider)
   {
      _Repository = repository;
      _ValidatorInstance = validator;
      _SearchStringParser = searchStringParser;

      _Adapter = new UserClaimAdapter();
   }

   public IList<UserClaim> GetAll(int maxNumberOfResults = 100)
   {
      throw new NotImplementedException();
   }

   public UserClaim GetById(int id)
   {
      throw new NotImplementedException();
   }

   public void Save(UserClaim saveThis)
   {
      throw new NotImplementedException();
   }

   public void DeleteById(int id)
   {
      throw new NotImplementedException();
   }

   public IList<UserClaim> SimpleSearch(
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

   public IList<UserClaim> Search(
      SearchMethod searchTypeUsername = SearchMethod.Contains,
      string searchValueUsername = null,
      SearchMethod searchTypeClaimName = SearchMethod.Contains,
      string searchValueClaimName = null,
      SearchMethod searchTypeClaimValue = SearchMethod.Contains,
      string searchValueClaimValue = null,
      SearchMethod searchTypeClaimLogicType = SearchMethod.Contains,
      string searchValueClaimLogicType = null,
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

   public IList<UserClaim> Search(Search search)
   {
      throw new NotImplementedException();
   }
}
