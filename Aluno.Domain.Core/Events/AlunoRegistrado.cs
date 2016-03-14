using System;
using Kernel.Domain.Core.Interfaces;

namespace Aluno.Domain.Core.Events
{
    public class AlunoRegistrado : IDomainEvent
    {
        public int Versao { get; set; }
        public DateTime DataOcorrencia { get; private set; }
        public Aluno AlunoCriado { get; private set; }

        public AlunoRegistrado(Aluno aluno)
        {
            this.AlunoCriado = aluno;
            this.DataOcorrencia = DateTime.Now;
        }
    }
}