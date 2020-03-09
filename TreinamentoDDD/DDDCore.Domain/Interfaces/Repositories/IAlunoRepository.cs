using DDDCore.Domain.Entities;
using System.Collections.Generic;

namespace DDDCore.Domain.Interfaces.Repositories
{
    public interface IAlunoRepository : IRepositoryBase<Aluno>
    {
        IEnumerable<Aluno> GetByName(string name);
    }
}
