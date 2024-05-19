using Microsoft.Extensions.DependencyInjection;
using System;

namespace Mazi.Pipeline.Common;

public interface ITypeRegistrationItem
{
   Type ImplementationType { get; }
   ServiceLifetime Lifetime { get; set; }
   Type ServiceType { get; }
}
