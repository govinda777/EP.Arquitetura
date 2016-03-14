using System;
using System.Collections.Generic;
using Matricula.Domain.Core.Cursos;

namespace Matricula.Domain.Core.Instrutores
{
    public class Instrutor
    {
        public Guid InstrutorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<Curso> Cursos { get; set; }
    }
}