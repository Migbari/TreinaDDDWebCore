using DDDCore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DDDCore.Infra.Data.EntityConfig
{
    public class MateriaConfiguration : EntityTypeConfiguration<Materia>
    {
        public MateriaConfiguration()
        {
            HasKey(d => d.Id);

            Property(d => d.Nome)
              .IsRequired()
              .HasMaxLength(15);
        }
    }
}
