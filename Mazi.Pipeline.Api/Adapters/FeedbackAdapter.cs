using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DomainModels;
using System;

namespace Mazi.Pipeline.Api.Adapters;

public partial class FeedbackAdapter : AdapterBase<Feedback, FeedbackEntity>
{
   protected override void PerformAdapt(Feedback fromValue, FeedbackEntity toValue)
   {
      throw new NotImplementedException();
   }

   protected override void PerformAdapt(FeedbackEntity fromValue, Feedback toValue)
   {
      throw new NotImplementedException();
   }
}
