﻿using Mazi.Pipeline.Common;
using System.Collections.Generic;

namespace Mazi.Pipeline.SqlServer;

public interface IRepository<T>
   where T : IInt32Identity
{
   IList<T> GetAll();
   IList<T> GetAll(int maxNumberOfRows, bool noIncludes = true);
   T GetById(int id);
   void Save(T saveThis);
   void Delete(T deleteThis);
}
