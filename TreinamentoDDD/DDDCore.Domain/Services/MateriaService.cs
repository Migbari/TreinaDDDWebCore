using DDDCore.Domain.Entities;
using DDDCore.Domain.Interfaces.Repositories;
using DDDCore.Domain.Interfaces.Services;

namespace DDDCore.Domain.Services
{
    public class MateriaService : ServiceBase<Materia>, IMateriaService
    {
        private readonly IRepositoryBase<Materia> _materiaService;
        public MateriaService(IRepositoryBase<Materia> materiaService)
            : base(materiaService)
        {
            _materiaService = materiaService;
        }
    }
}
