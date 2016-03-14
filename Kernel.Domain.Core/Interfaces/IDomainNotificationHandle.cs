using System.Collections.Generic;

namespace Kernel.Domain.Core.Interfaces
{
    public interface IDomainNotificationHandle<T> : IHandles<T> where T : IDomainEvent
    {
        List<T> Notify();
        bool HasNotifications();
    }
}