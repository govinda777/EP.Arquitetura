using System.Data.Entity.ModelConfiguration;
using Aluno.Data.Pocos;

namespace Aluno.Data.EntityConfig
{
    public class AlunoConfig : EntityTypeConfiguration<AlunoPoco>
    {
        public AlunoConfig()
        {
            HasKey(c => c.AlunoId);

            ToTable("Alunos");
        }
    }
}