using DDDCore.Domain.Application;
using DDDCore.Domain.Entities;
using DDDCore.Domain.Interfaces.AppServices;
using DDDCore.Domain.Interfaces.Services;

namespace DDDCore.Application
{
    public class MateriaAppService : AppServiceBase<Materia>, IMateriaAppService
    {
        private readonly IServiceBase<Materia> _serviceBase;
        public MateriaAppService(IServiceBase<Materia> serviceBase)
            : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }

    }
}
