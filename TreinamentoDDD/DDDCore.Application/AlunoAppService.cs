using DDDCore.Domain.Application;
using DDDCore.Domain.Entities;
using DDDCore.Domain.Interfaces.AppServices;
using DDDCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDCore.Application
{
    public class AlunoAppService : AppServiceBase<Aluno>, IAlunoAppService
    {
        private readonly IServiceBase<Aluno> _serviceBase;
        public AlunoAppService(IServiceBase<Aluno> serviceBase)
            : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }
        public IEnumerable<Aluno> GetByName(string name)
        {
            return _serviceBase.GetAll().ToList().Where(p => p.Nome.StartsWith(name));
        }
    }
}
