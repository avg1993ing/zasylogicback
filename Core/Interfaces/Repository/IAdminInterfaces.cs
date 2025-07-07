using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IAdminInterfaces : IDisposable
    {
        IClienteRepository clienteRepository { get; }
        IMotivoRepository motivoRepository { get; }
    }
}
