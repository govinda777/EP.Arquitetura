using System;
using System.Collections.Generic;
using Aluno.Application.ViewModels;
using Aluno.Data.Read.Models;

namespace Aluno.Application.Interfaces
{
    public interface IAlunoAppService
    {
        AlunoViewModel Adicionar(AlunoViewModel aluno);
        AlunoEndereco ObterPorId(Guid id);
        IEnumerable<AlunoEndereco> ObterTodos(); 
         
    }
}