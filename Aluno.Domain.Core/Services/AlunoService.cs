using Aluno.Domain.Core.Events;
using Aluno.Domain.Core.Interfaces;
using Aluno.Domain.Core.Validations.Alunos;
using Kernel.Domain.Core.Events;

namespace Aluno.Domain.Core.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public Aluno Adicionar(Aluno aluno)
        {
            if (!aluno.IsValid())
                return aluno;

            aluno.ValidationResult = new AlunoAptoParaCadastroValidation(_alunoRepository).Validate(aluno);
            DomainEvents.Raise(new AlunoRegistrado(aluno));

            return aluno;
        }
    }
}