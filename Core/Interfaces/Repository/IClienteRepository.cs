using Core.Dtos;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<List<Cliente>> GetAllFilter(DateTime? fecha);
        Task<bool> Validate(string telefono);
    }
}
