using System;
using Aluno.Domain.Core.Events;
using Kernel.Domain.Core.Interfaces;

namespace Aluno.Infra.Handles
{
    public class UserRegisteredHanle : IHandles<AlunoRegistrado>
    {
        public void Handle(AlunoRegistrado args)
        {
            // Enviar Email
            Console.WriteLine("enviando email para " + args.AlunoCriado.Email);
        }
    }
}
