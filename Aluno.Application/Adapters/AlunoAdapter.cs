using Aluno.Application.ViewModels;
using Aluno.Domain.Core;
using Kernel.Domain.Core;

namespace Aluno.Application.Adapters
{
    public class AlunoAdapter
    {
        public static Domain.Core.Aluno ToDomainModel(AlunoViewModel alunoViewModel)
        {
            var aluno = Domain.Core.Aluno.Factory.NovoAluno(
                alunoViewModel.AlunoId,
                alunoViewModel.Nome,
                alunoViewModel.CPF,
                alunoViewModel.Email);
            
            return aluno;
        }
    }
}