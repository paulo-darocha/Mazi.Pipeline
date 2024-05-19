using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.Api.DomainModels;
using System;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.ServiceLayers;

public class CoreFieldsServiceLayerBase<T>(IUsernameProvider usernameProvider)
   where T : CoreFieldsDomainModelBase
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

   protected void PopulateAuditFieldsBeforeSave(T toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void OnPopulateAuditFieldsBeforeSave(T toValue)
   {
      throw new NotImplementedException();
   }

   protected virtual void PopulateAuditFieldsBeforeSave(
      List<CoreFieldsDomainModelBase> values
   )
   {
      throw new NotImplementedException();
   }

   protected virtual void PopulateAuditFieldsBeforeSave(
      CoreFieldsDomainModelBase toValue
   )
   {
      throw new NotImplementedException();
   }

   protected virtual void PopulateFieldsFromEntityAfterSave(
      List<CoreFieldsEntityBase> fromValues,
      List<CoreFieldsDomainModelBase> toValues
   )
   {
      throw new NotImplementedException();
   }

   protected virtual void PopulateFieldsFromEntityAfterSave(
      CoreFieldsEntityBase fromValue,
      CoreFieldsDomainModelBase toValue
   )
   {
      throw new NotImplementedException();
   }
}
