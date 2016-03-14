using System;
using System.Collections.Generic;
using Aluno.Data.Read.Models;

namespace Aluno.Data.Read.Interfaces
{
    public interface IAlunoReadRepository
    {
        IEnumerable<AlunoEndereco> ObterTodos();
        AlunoEndereco ObterPorId(Guid id);
    }
}