using Kernel.Infra.CQRS;

namespace Aluno.CommandStack.Events
{
    public class AdicionarAlunoSolicitacaoEvent : Event
    {
        public AdicionarAlunoSolicitacaoEvent(int courtId, int hour, int length, string userName)
        {
            CourtId = courtId;
            Hour = hour;
            Length = length;
            UserName = userName;
        }

        public int CourtId { get; private set; }
        public int Hour { get; private set; }
        public int Length { get; private set; }
        public string UserName { get; private set; }
    }
}