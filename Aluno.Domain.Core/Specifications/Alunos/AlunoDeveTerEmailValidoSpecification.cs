using Aluno.Domain.Core.Validations.Documentos;
using DomainValidation.Interfaces.Specification;

namespace Aluno.Domain.Core.Specifications.Alunos
{
    public class AlunoDeveTerEmailValidoSpecification : ISpecification<Aluno>
    {
        public bool IsSatisfiedBy(Aluno aluno)
        {
            return EmailValidation.Validate(aluno.Email);
        }
    }
}