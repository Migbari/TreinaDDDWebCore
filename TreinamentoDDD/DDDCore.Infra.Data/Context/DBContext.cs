using DDDCore.Domain.Entities;
using DDDCore.Domain.Entities.Associative;
using Microsoft.EntityFrameworkCore;


namespace DDDCore.Infra.Data.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<AlunoMateria> AlunoMateria { get; set; }
    }
}
