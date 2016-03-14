using Aluno.CommandStack.Handlers;
using Aluno.CommandStack.Sagas;
using Kernel.Infra.CQRS;
using Kernel.Infra.CQRS.EventStore;

namespace Aluno.Application.Bus
{
    public class BusConfig
    {
        public static IBus Bus { get; set; }
        public static void Initialize()
        {
            Bus = new InMemoryBus(new SqlEventStore());

            Bus.RegisterSaga<AdicionarAlunoSaga>();
            Bus.RegisterHandler<AdicionarAlunoRejeicaoHandler>();
            Bus.RegisterHandler<EmailHandler>();
        }
    }
}