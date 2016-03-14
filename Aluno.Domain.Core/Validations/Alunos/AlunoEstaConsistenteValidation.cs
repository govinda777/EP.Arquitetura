using Aluno.Domain.Core.Specifications.Alunos;
using DomainValidation.Validation;

namespace Aluno.Domain.Core.Validations.Alunos
{
    public class AlunoEstaConsistenteValidation : Validator<Aluno>
    {
        public AlunoEstaConsistenteValidation()
        {
            var CPFAluno = new AlunoDeveTerCpfValidoSpecification();
            var alunoEmail = new AlunoDeveTerEmailValidoSpecification();

            base.Add("CPFCliente", new Rule<Aluno>(CPFAluno, "Cliente informou um CPF inválido."));
            base.Add("clienteEmail", new Rule<Aluno>(alunoEmail, "Cliente informou um e-mail inválido."));
        }
    }
}