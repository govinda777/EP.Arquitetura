using System;
using Kernel.Domain.Core;

namespace Matricula.Domain.Core.Cursos
{
    public class CursoId : Aggregate
    {
        public CursoId()
        {
            
        }

        public CursoId(Guid id) : base(id)
        {
            
        }
    }
}