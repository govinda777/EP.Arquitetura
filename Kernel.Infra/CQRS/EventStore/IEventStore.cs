namespace Kernel.Infra.CQRS.EventStore
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}