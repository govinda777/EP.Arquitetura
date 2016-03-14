using System;

namespace Kernel.Domain.Core.Interfaces
{
    public interface IAggregate
    {
        Guid Id { get; }
    }
}