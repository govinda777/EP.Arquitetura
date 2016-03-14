using Aluno.Domain.Core.Interfaces;
using Aluno.Domain.Core.Specifications.Alunos;
using DomainValidation.Validation;

namespace Aluno.Domain.Core.Validations.Alunos
{
    public class AlunoAptoParaCadastroValidation : Validator<Aluno>
    {
        public AlunoAptoParaCadastroValidation(IAlunoRepository alunoRepository)
        {
            var cpfDuplicado = new AlunoDevePossuirCPFUnicoSpecification(alunoRepository);
            var emailDuplicado = new AlunoDevePossuirEmailUnicoSpecification(alunoRepository);

            base.Add("cpfDuplicado", new Rule<Aluno>(cpfDuplicado, "CPF já cadastrado!"));
            base.Add("emailDuplicado", new Rule<Aluno>(emailDuplicado, "E-mail já cadastrado!"));
        }
    }
}