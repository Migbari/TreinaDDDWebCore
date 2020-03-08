using DDDCore.Domain.Entities.Associative;
using System.Data.Entity.ModelConfiguration;

namespace DDDCore.Infra.Data.EntityConfig
{
    public class AlunoMateriaConfiguration : EntityTypeConfiguration<AlunoMateria>
    {
        public AlunoMateriaConfiguration()
        {
            HasRequired(p => p.Aluno)
              .WithMany()
              .HasForeignKey(p => p.AlunoId);

            HasRequired(p => p.Materia)
                    .WithMany()
                    .HasForeignKey(p => p.MateriaId);

            Property(p => p.MesAno)
                .HasMaxLength(6)
                .HasColumnType("char");

            Property(p => p.Nota)
                .HasColumnType("decimal").HasPrecision(3, 1);       
        }
    }
}
