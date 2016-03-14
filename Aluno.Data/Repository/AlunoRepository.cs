using System;
using System.Linq;
using Aluno.Data.Context;
using Aluno.Data.Read.Context;
using Aluno.Domain.Core.Interfaces;
using Kernel.Infra.CQRS;
using Kernel.Infra.CQRS.Repositories;

namespace Aluno.Data.Repository
{
    public class AlunoRepository : IAlunoRepository, IRepository
    {
        private readonly AlunoContext _db;
        private readonly AlunoReadContext _dbRead;

        public AlunoRepository()
        {
            _db = new AlunoContext();
            _dbRead = new AlunoReadContext();
        }

        public int Adicionar(Domain.Core.Aluno aluno)
        {
            var alunoPoco = AlunoAdapter.AlunoToPoco(aluno);
            _db.Alunos.Add(alunoPoco);

            _dbRead.AlunoEnderecos.Add(AlunoAdapter.PocoToReadModel(alunoPoco));
            _dbRead.SaveChanges();

            return _db.SaveChanges();
        }

        public Domain.Core.Aluno ObterPorId(Guid id)
        {
            return AlunoAdapter.PocoToDomain(_db.Alunos.Find(id));
        }

        public Domain.Core.Aluno ObterPorCpf(string cpf)
        {
            return AlunoAdapter.PocoToDomain(_db.Alunos.FirstOrDefault(a=>a.CPF == cpf));
        }

        public Domain.Core.Aluno ObterPorEmail(string email)
        {
            return AlunoAdapter.PocoToDomain(_db.Alunos.FirstOrDefault(a => a.Email == email));
        }

        public T GetById<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }

        public CommandResponse CreateFromRequest<T>(T item) where T : class
        {
            var request = item as Domain.Core.Aluno;
            var count = Adicionar(request);

            var alunoPoco = AlunoAdapter.AlunoToPoco(request);

            var response = new CommandResponse(count > 0, alunoPoco.AlunoId) { RequestId = alunoPoco.RequestId };
            return response;
        }

    }
}