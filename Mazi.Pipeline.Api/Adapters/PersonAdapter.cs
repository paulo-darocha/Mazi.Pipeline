using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DomainModels;
using System;

namespace Mazi.Pipeline.Api.Adapters;

public partial class PersonAdapter : AdapterBase<Person, PersonEntity>
{
   protected override void PerformAdapt(Person fromValue, PersonEntity toValue)
   {
      throw new NotImplementedException();
   }

   protected override void PerformAdapt(PersonEntity fromValue, Person toValue)
   {
      throw new NotImplementedException();
   }
}
