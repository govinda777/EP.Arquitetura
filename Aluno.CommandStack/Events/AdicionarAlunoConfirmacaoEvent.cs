using System;
using Kernel.Infra.CQRS;

namespace Aluno.CommandStack.Events
{
    public class AdicionarAlunoConfirmacaoEvent : Event
    {
        public AdicionarAlunoConfirmacaoEvent(Guid requestId, Guid id)
        {
            RequestId = requestId;
            Id = id; 
            When = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public Guid RequestId { get; private set; }
        public DateTime When { get; private set; }
    }
}