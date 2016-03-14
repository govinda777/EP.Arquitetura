using System;
using System.Collections.Generic;

namespace Kernel.Domain.Core.Interfaces
{
    public interface IContainer
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}