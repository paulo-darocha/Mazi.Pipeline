using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DomainModels;
using System.Collections.Generic;
using System;

namespace Mazi.Pipeline.Api.ServiceLayers;

public abstract class ServiceLayerBase<T>(IUsernameProvider usernameProvider)
   where T : DomainModelBase
{
   protected IUsernameProvider _usernameProvider = usernameProvider;

   protected virtual void BeforeReturnFromGet(T returnValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void BeforeReturnFromGet(IList<T> returnValues)
   {
      throw new NotImplementedException();
   }

   protected virtual void PopulateAuditFieldsBeforeSave(T toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void OnPopulateAuditFieldsBeforeSave(T toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void PopulateAuditFieldsBeforeSave(DomainModelBase toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void PopulateFieldsFromEntityAfterSave(
      List<EntityBase> fromValues,
      List<DomainModelBase> toValues
   )
   {
      throw new NotImplementedException();
   }

   protected virtual void PopulateFieldsFromEntityAfterSave(
      EntityBase fromValue,
      DomainModelBase toValue
   )
   {
      throw new NotImplementedException();
   }
}
