using System;
using Aluno.CommandStack.Events;
using Aluno.Infra.Utils;
using Kernel.Infra.CQRS;
using Kernel.Infra.CQRS.EventStore;

namespace Aluno.CommandStack.Handlers
{
    public class EmailHandler : Handler,
        IHandleMessage<AdicionarAlunoRejeicaoEvent>,
        IHandleMessage<AdicionarAlunoConfirmacaoEvent>
    {
        public EmailHandler(IEventStore eventStore)
            : base(eventStore)
        {

        }

        public void Handle(AdicionarAlunoRejeicaoEvent message)
        {
            var body = string.Format("Sua solicitação {0} não pode ser completada.",
                message.RequestId);
            EmailService.Send("user@company.com", body);
        }

        public void Handle(AdicionarAlunoConfirmacaoEvent message)
        {
            var body = string.Format("Parabéns! Você foi registrado, protocolo número: {0}.",
                message.Id);
            EmailService.Send("user@company.com", body);
        }
    }
}