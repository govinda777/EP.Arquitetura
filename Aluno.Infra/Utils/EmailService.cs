

using System;
using Aluno.Data.Context;
using Aluno.Data.Pocos;

namespace Aluno.Infra.Utils
{
    public class EmailService
    {
        public static void Send(string address, string message)
        {
            // TODO: Enviar Email

            using (var db = new AlunoContext())
            {
                var email = new AlunoEmailsEnviados
                {
                    Address = address,
                    Body = message,
                    Sent = DateTime.Now
                };
                //db.AlunoEmailsEnviados.Add(email);
                //db.SaveChanges();
            }
        }
    }
}