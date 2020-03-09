using DDDCore.Domain.Entities;
using DDDCore.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DDDCore.Infra.Data.Repositories
{
    public class AlunoRepository : RepositoryBase<Aluno>, IAlunoRepository
    {
        public IEnumerable<Aluno> GetByName(string name)
        {
            return Db.Aluno.ToList().Where(p => p.Nome.StartsWith(name));
        }
    }
}
