using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.ServiceLayers;
using System;

namespace Mazi.Pipeline.Api.Adapters;

public partial class ConfigurationItemAdapter
   : AdapterBase<ConfigurationItem, ConfigurationItemEntity>
{
   protected override void PerformAdapt(
      ConfigurationItem fromValue,
      ConfigurationItemEntity toValue
   )
   {
      throw new NotImplementedException();
   }

   protected override void PerformAdapt(
      ConfigurationItemEntity fromValue,
      ConfigurationItem toValue
   )
   {
      throw new NotImplementedException();
   }
}
