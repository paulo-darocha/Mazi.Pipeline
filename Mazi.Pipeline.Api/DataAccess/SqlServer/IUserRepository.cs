﻿using Mazi.Pipeline.Api.DataAccess.Entities;
using Mazi.Pipeline.SqlServer;

namespace Mazi.Pipeline.Api.DataAccess.SqlServer;

public partial interface IUserRepository : ISearchableRepository<UserEntity> { }
