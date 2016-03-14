using System.Data.Entity.ModelConfiguration;
using Aluno.Data.Pocos;

namespace Aluno.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<EnderecoPoco>
    {
        public EnderecoConfig()
        {
            HasKey(c => c.EnderecoId);

            HasRequired(p => p.Aluno)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(c => c.AlunoId);

            ToTable("EnderecoAluno");
        }
    }
}