using System;
using Kernel.Infra.CQRS;

namespace Aluno.CommandStack.Events
{
    public class AdicionarAlunoRejeicaoEvent : Event
    {
        public AdicionarAlunoRejeicaoEvent(Guid requestId, string reason = "")
        {
            RequestId = requestId;
            Reason = reason;
        }

        public Guid RequestId { get; private set; }
        public string Reason { get; private set; }
    }
}