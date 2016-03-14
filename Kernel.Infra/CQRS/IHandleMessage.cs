namespace Kernel.Infra.CQRS
{
    public interface IHandleMessage<in T>
    {
        void Handle(T message);
    }
}