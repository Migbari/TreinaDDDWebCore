using DDDCore.Domain.Entities;
using DDDCore.Domain.Entities.Associative;
using DDDCore.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace DDDCore.Infra.Data.Context
{
    public class MigrationDbContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<AlunoMateria> AlunoMateria { get; set; }
        public MigrationDbContext()
            : base("CnxDbEscola")
        {
            Database.CreateIfNotExists();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Apenas para usar as convenções conforme usamos no .Net Framework
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Apenas para usar as convenções conforme usamos no.Net Framework
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new AlunoConfiguration());
            modelBuilder.Configurations.Add(new MateriaConfiguration());
            modelBuilder.Configurations.Add(new AlunoMateriaConfiguration());

            modelBuilder.Entity<Aluno>().ToTable("TB_ALUNO");
            modelBuilder.Entity<Materia>().ToTable("TB_MATERIA");
            modelBuilder.Entity<AlunoMateria>().ToTable("TB_ALUNO_MATERIA");
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
