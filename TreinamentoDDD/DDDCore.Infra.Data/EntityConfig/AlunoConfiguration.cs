using DDDCore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DDDCore.Infra.Data.EntityConfig
{
    public class AlunoConfiguration : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfiguration()
        {
            HasKey(d => d.Id);

            Property(d => d.Nome)
              .IsRequired()
              .HasMaxLength(150);

            Property(d => d.TelefoneResidencial)
              .IsRequired()
              .HasMaxLength(11);

            Property(d => d.TelefoneCelular)
             .IsRequired()
             .HasMaxLength(11);

            Property(d => d.Ativo)
             .IsRequired();

            Property(d => d.Datacadastro)
             .IsRequired();
        }
    }
}
