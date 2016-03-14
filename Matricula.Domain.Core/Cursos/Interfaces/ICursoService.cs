using System;

namespace Matricula.Domain.Core.Cursos.Interfaces
{
    public interface ICursoService
    {
        void Adicionar(Curso curso);
        Curso ObterPorId(Guid id); 
    }
}