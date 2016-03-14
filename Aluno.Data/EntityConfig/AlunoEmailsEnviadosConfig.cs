using System.Data.Entity.ModelConfiguration;
using Aluno.Data.Pocos;

namespace Aluno.Data.EntityConfig
{
    public class AlunoEmailsEnviadosConfig : EntityTypeConfiguration<AlunoEmailsEnviados>
    {
        public AlunoEmailsEnviadosConfig()
        {
            HasKey(e => e.Id);

            ToTable("AlunoEmailsEnviados");
        }
    }
}