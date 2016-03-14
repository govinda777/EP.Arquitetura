using System;
using Kernel.Domain.Core.Interfaces;

namespace Kernel.Domain.Core
{
    public class Aggregate : IAggregate
    {
        public Aggregate()
        {
            this.Id = Guid.NewGuid();
        }

        public Aggregate(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; protected set; }
    }
}