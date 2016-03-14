using System;
using Kernel.Domain.Core;

namespace Matricula.Domain.Core.Instrutores
{
    public class InstrutorId : Aggregate
    {
        public InstrutorId()
        {

        }

        public InstrutorId(Guid id) : base(id)
        {

        }
    }
}