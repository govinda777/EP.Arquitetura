namespace Kernel.Domain.Core.Interfaces
{
    public interface IHandles<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}