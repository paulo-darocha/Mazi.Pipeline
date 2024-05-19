using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DomainModels;
using System;

namespace Mazi.Pipeline.Api.Adapters;

public partial class LogEntryAdapter : AdapterBase<LogEntry, LogEntryEntity>
{
   protected override void PerformAdapt(LogEntry fromValue, LogEntryEntity toValue)
   {
      throw new NotImplementedException();
   }

   protected override void PerformAdapt(LogEntryEntity fromValue, LogEntry toValue)
   {
      throw new NotImplementedException();
   }
}
