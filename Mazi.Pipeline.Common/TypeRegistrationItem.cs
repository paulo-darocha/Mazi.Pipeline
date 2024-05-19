using Microsoft.Extensions.DependencyInjection;
using System;

namespace Mazi.Pipeline.Common;

public class TypeRegistrationItem<TService, TImplementation>(
   ServiceLifetime lifetime = ServiceLifetime.Transient
) : ITypeRegistrationItem
   where TService : class
   where TImplementation : class, TService
{
   public ServiceLifetime Lifetime { get; set; } = lifetime;
   public Type ServiceType => typeof(TService);
   public Type ImplementationType => typeof(TImplementation);
}
