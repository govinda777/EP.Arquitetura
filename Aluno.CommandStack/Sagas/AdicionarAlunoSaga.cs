using Aluno.CommandStack.Commands;
using Aluno.CommandStack.Events;
using Aluno.Data.Repository;
using Kernel.Infra.CQRS;
using Kernel.Infra.CQRS.EventStore;
using Kernel.Infra.CQRS.Repositories;

namespace Aluno.CommandStack.Sagas
{
    public class AdicionarAlunoSaga : Saga,
            IStartWithMessage<AdicionarAlunoCommand>
    {
        private readonly IRepository _repository;

        public AdicionarAlunoSaga(IBus bus, IEventStore eventStore)
            : base(bus, eventStore)
        {
            _repository = new AlunoRepository();
        }

        public AdicionarAlunoSaga(IBus bus, IEventStore eventStore, IRepository repository)
            : base(bus, eventStore)
        {
            _repository = repository;
        }

        public void Handle(AdicionarAlunoCommand message)
        {
            var request = Domain.Core.Aluno.Factory.NovoAluno(
                message.AlunoId,
                message.Nome,
                message.CPF,
                message.Email);

            var response = _repository.CreateFromRequest(request);
            if (!response.Success)
            {
                var rejected = new AdicionarAlunoRejeicaoEvent(request.AlunoId.Id, response.Description);
                Bus.RaiseEvent(rejected);
                return;
            }

            var created = new AdicionarAlunoConfirmacaoEvent(request.AlunoId.Id, response.AggregateId);
            Bus.RaiseEvent(created);
        }
    }
}