using Aluno.Domain.Core.Validations.Documentos;
using DomainValidation.Interfaces.Specification;

namespace Aluno.Domain.Core.Specifications.Alunos
{
    public class AlunoDeveTerCpfValidoSpecification : ISpecification<Aluno>
    {
        public bool IsSatisfiedBy(Aluno aluno)
        {
            return CPFValidation.Validar(aluno.CPF.Numero);
        }
    }
}