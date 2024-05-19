using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DomainModels;
using System;

namespace Mazi.Pipeline.Api.Adapters;

public partial class LookupAdapter : AdapterBase<Lookup, LookupEntity>
{
   protected override void PerformAdapt(Lookup fromValue, LookupEntity toValue)
   {
      throw new NotImplementedException();
   }

   protected override void PerformAdapt(LookupEntity fromValue, Lookup toValue)
   {
      throw new NotImplementedException();
   }
}
