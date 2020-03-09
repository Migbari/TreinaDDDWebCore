using DDDCore.Domain.Entities;
using DDDCore.Domain.Interfaces.Repositories;
using DDDCore.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace DDDCore.Domain.Services
{
    public class AlunoService : ServiceBase<Aluno>, IAlunoService
    {
        private readonly IRepositoryBase<Aluno> _repositoryBase;
        public AlunoService(IRepositoryBase<Aluno> repositoryBase)
            : base(repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public IEnumerable<Aluno> GetByName(string name)
        {
            return _repositoryBase.GetAll().ToList().Where(p => p.Nome.StartsWith(name));
        }
    }
}
