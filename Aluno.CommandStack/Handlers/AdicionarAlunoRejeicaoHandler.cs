using Aluno.CommandStack.Events;
using Kernel.Infra.CQRS;
using Kernel.Infra.CQRS.EventStore;

namespace Aluno.CommandStack.Handlers
{
    public class AdicionarAlunoRejeicaoHandler : Handler,
        IHandleMessage<AdicionarAlunoRejeicaoEvent>
    {
        public AdicionarAlunoRejeicaoHandler(IEventStore eventStore) 
            : base(eventStore)
        {
        }

        public void Handle(AdicionarAlunoRejeicaoEvent message)
        {
            throw new System.NotImplementedException();
        }
    }
}