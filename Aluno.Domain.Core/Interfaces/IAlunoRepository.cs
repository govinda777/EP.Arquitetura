using System;
using Kernel.Infra.CQRS;

namespace Aluno.Domain.Core.Interfaces
{
    public interface IAlunoRepository
    {
        int Adicionar(Aluno aluno);
        Aluno ObterPorId(Guid id);
        Aluno ObterPorCpf(string cpf);
        Aluno ObterPorEmail(string email);
        T GetById<T>(int id) where T : class;
        CommandResponse CreateFromRequest<T>(T item) where T : class;
    }
}