﻿using Mazi.Pipeline.Common;
using System.Collections.Generic;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial interface IServiceLayer<T>
{
   IList<T> GetAll(int maxNumberOfResults = 100);

   T GetById(int id);

   void Save(T saveThis);

   void DeleteById(int id);

   IList<T> Search(Search search);
}
