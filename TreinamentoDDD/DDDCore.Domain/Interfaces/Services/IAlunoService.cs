using DDDCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCore.Domain.Interfaces.Services
{
    public interface IAlunoService : IServiceBase<Aluno>
    {
        IEnumerable<Aluno> GetByName(string name);
    }
}
