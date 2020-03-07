using DDDCore.Domain.Entities;
using DDDCore.Domain.Entities.Associative;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DDDCore.Infra.Data.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<AlunoMateria> AlunoMateria { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("TB_ALUNO");
            modelBuilder.Entity<Materia>().ToTable("TB_MATERIA");
            modelBuilder.Entity<Aluno>().ToTable("TB_ALUNO_X_MATERIA");

            Convention convention = new Convention();
            convention.Properties()
                .Where(p => p.Name == p.ReflectedType + "Id")
                .Configure(p => p.IsKey());

            convention.Properties<string>()
            .Configure(p => p.HasMaxLength(100));

            convention.Properties<string>()
            .Configure(p => p.HasColumnType("varchar"));
        }
    }
}
