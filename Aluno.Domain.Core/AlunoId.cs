using System;
using Kernel.Domain.Core;

namespace Aluno.Domain.Core
{
    public class AlunoId : Aggregate
    {
        public AlunoId()
        {
            
        }

        public AlunoId(Guid id) : base(id)
        {
            
        }
    }
}