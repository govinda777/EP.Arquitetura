using Aluno.Data.Pocos;
using Aluno.Data.Read.Models;

namespace Aluno.Data.Repository
{
    public class AlunoAdapter
    {
        public static AlunoPoco AlunoToPoco(Domain.Core.Aluno aluno)
        {
            var alunoPoco = new AlunoPoco()
            {
                AlunoId = aluno.AlunoId.Id,
                CPF = aluno.CPF.Numero,
                Email = aluno.Email,
                Nome = aluno.Nome,
                Ativo = false
            };

            return alunoPoco;
        }

        public static Domain.Core.Aluno PocoToDomain(AlunoPoco alunoPoco)
        {
            return alunoPoco == null ? null : Domain.Core.Aluno.Factory.NovoAluno(alunoPoco.AlunoId, alunoPoco.Nome, alunoPoco.CPF, alunoPoco.Email);
        }

        public static AlunoEndereco PocoToReadModel(AlunoPoco alunoPoco)
        {
            var alunoEndereco = new AlunoEndereco()
            {
                AlunoId = alunoPoco.AlunoId,
                CPF = alunoPoco.CPF,
                Email = alunoPoco.Email,
                Nome = alunoPoco.Nome,
                Ativo = false
            };

            return alunoEndereco;
        }
    }
}