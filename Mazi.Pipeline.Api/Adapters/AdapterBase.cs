using Mazi.Pipeline.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mazi.Pipeline.Api.Adapters;

public abstract class AdapterBase<TType1, TType2>
   where TType1 : class, IInt32Identity, new()
   where TType2 : class, IInt32Identity, IDeleteable, new()
{
   public virtual void Adapt(TType1 fromValue, TType2 toValue)
   {
      throw new NotImplementedException();
   }

   public virtual void Adapt(TType2 fromValue, TType1 toValue)
   {
      throw new NotImplementedException();
   }

   public virtual void Adapt(IList<TType1> fromValues, IList<TType2> toValues)
   {
      throw new NotImplementedException();
   }

   public virtual void Adapt(IList<TType2> fromValues, IList<TType1> toValues)
   {
      throw new NotImplementedException();
   }

   protected virtual void ProcessDeletes(
      IList<TType1> fromValues,
      IList<TType2> toValues
   )
   {
      throw new NotImplementedException();
   }

   protected virtual AdapterActions BeforeAdapt(TType1 fromValue, TType2 toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual AdapterActions BeforeAdapt(TType2 fromValue, TType1 toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void BeforeAdapt(
      IList<TType1> fromValues,
      IList<TType2> toValues
   )
   {
      throw new NotImplementedException();
   }

   protected virtual void BeforeAdapt(
      IList<TType2> fromValues,
      IList<TType1> toValues
   )
   {
      throw new NotImplementedException();
   }

   protected virtual void AfterAdapt(TType1 fromValue, TType2 toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void AfterAdapt(TType2 fromValue, TType1 toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void AfterAdapt(
      IList<TType1> fromValues,
      IList<TType2> toValues
   )
   {
      throw new NotImplementedException();
   }

   protected virtual void AfterAdapt(
      IList<TType2> fromValues,
      IList<TType1> toValues
   )
   {
      throw new NotImplementedException();
   }

   protected abstract void PerformAdapt(TType1 fromValue, TType2 toValue);
   protected abstract void PerformAdapt(TType2 fromValue, TType1 toValue);

   protected void PerformAdapt(IList<TType1> fromValues, IList<TType2> toValues)
   {
      throw new NotImplementedException();
   }

   protected void PerformAdapt(IList<TType2> fromValues, IList<TType1> toValues)
   {
      throw new NotImplementedException();
   }

   protected virtual TType1 FindById(IList<TType1> values, int id)
   {
      throw new NotImplementedException();
   }

   protected virtual TType2 FindById(IList<TType2> values, int id)
   {
      throw new NotImplementedException();
   }
}
