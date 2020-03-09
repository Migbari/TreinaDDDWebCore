using DDDCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCore.Domain.Interfaces.AppServices
{
    public interface IAlunoAppService : IAppServiceBase<Aluno>
    {
        IEnumerable<Aluno> GetByName(string name);
    }
}
