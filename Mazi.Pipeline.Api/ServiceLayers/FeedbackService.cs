using Mazi.Pipeline.Api.Adapters;
using Mazi.Pipeline.Api.DataAccess.SqlServer;
using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial class FeedbackService
   : CoreFieldsServiceLayerBase<Feedback>,
      IFeedbackService
{
   private IFeedbackRepository _Repository;
   private FeedbackAdapter _Adapter;
   private IValidatorStrategy<Feedback> _ValidatorInstance;
   private ISearchStringParserStrategy _SearchStringParser;

   public FeedbackService(
      IFeedbackRepository repository,
      IValidatorStrategy<Feedback> validator,
      IUsernameProvider usernameProvider,
      ISearchStringParserStrategy searchStringParser
   )
      : base(usernameProvider)
   {
      _Repository = repository;
      _ValidatorInstance = validator;
      _SearchStringParser = searchStringParser;
      _Adapter = new FeedbackAdapter();
   }

   public IList<Feedback> GetAll(int maxNumberOfResults = 100)
   {
      throw new NotImplementedException();
   }

   public Feedback GetById(int id)
   {
      throw new NotImplementedException();
   }

   public void Save(Feedback saveThis)
   {
      throw new NotImplementedException();
   }

   public void DeleteById(int id)
   {
      throw new NotImplementedException();
   }

   public IList<Feedback> SimpleSearch(
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
      search.AddArgument(
         "FeedbackType",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "Sentiment",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "Subject",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "FeedbackText",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "Username",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "FirstName",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "LastName",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "Referrer",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "UserAgent",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "IpAddress",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "Status",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "CreatedBy",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
      search.AddArgument(
         "LastModifiedBy",
         SearchMethod.Contains,
         searchValue,
         SearchOperator.Or
      );
   }

   public IList<Feedback> Search(
      SearchMethod searchTypeFeedbackType = SearchMethod.Contains,
      string searchValueFeedbackType = null,
      SearchMethod searchTypeSentiment = SearchMethod.Contains,
      string searchValueSentiment = null,
      SearchMethod searchTypeSubject = SearchMethod.Contains,
      string searchValueSubject = null,
      SearchMethod searchTypeFeedbackText = SearchMethod.Contains,
      string searchValueFeedbackText = null,
      SearchMethod searchTypeUsername = SearchMethod.Contains,
      string searchValueUsername = null,
      SearchMethod searchTypeFirstName = SearchMethod.Contains,
      string searchValueFirstName = null,
      SearchMethod searchTypeLastName = SearchMethod.Contains,
      string searchValueLastName = null,
      SearchMethod searchTypeReferrer = SearchMethod.Contains,
      string searchValueReferrer = null,
      SearchMethod searchTypeUserAgent = SearchMethod.Contains,
      string searchValueUserAgent = null,
      SearchMethod searchTypeIpAddress = SearchMethod.Contains,
      string searchValueIpAddress = null,
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

   public IList<Feedback> Search(Search search)
   {
      throw new NotImplementedException();
   }
}
