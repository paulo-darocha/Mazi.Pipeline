using Mazi.Pipeline.Api.Adapters;
using Mazi.Pipeline.Api.DataAccess.SqlServer;
using Mazi.Pipeline.Api.DomainModels;
using Mazi.Pipeline.Common;
using System.Collections.Generic;
using System;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial class LogEntryService : ServiceLayerBase<LogEntry>, ILogEntryService
{
   private ILogEntryRepository _Repository;
   private LogEntryAdapter _Adapter;
   private IValidatorStrategy<LogEntry> _ValidatorInstance;
   private ISearchStringParserStrategy _SearchStringParser;

   public LogEntryService(
      ILogEntryRepository repository,
      IValidatorStrategy<LogEntry> validatorInstance,
      IUsernameProvider usernameProvider,
      ISearchStringParserStrategy searchStringParser
   )
      : base(usernameProvider)
   {
      _Repository = repository;
      _Adapter = new LogEntryAdapter();
      _ValidatorInstance = validatorInstance;
      _SearchStringParser = searchStringParser;
   }

   public IList<LogEntry> GetAll(int maxNumberOfResults = 100)
   {
      throw new NotImplementedException();
   }

   public LogEntry GetById(int id)
   {
      throw new NotImplementedException();
   }

   public void Save(LogEntry saveThis)
   {
      throw new NotImplementedException();
   }

   public void DeleteById(int id)
   {
      throw new NotImplementedException();
   }

   public IList<LogEntry> SimpleSearch(
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

   public IList<LogEntry> Search(
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
   )
   {
      throw new NotImplementedException();
   }

   public IList<LogEntry> Search(Search search)
   {
      throw new NotImplementedException();
   }
}
