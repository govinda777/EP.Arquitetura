using System;

namespace Matricula.Domain.Core.Cursos.Interfaces
{
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
        Curso ObterPorId(Guid id);
    }
}