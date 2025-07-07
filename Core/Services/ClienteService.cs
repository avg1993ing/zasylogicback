using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Repository;
using Core.Interfaces.Services;

namespace Core.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public ClienteService(IAdminInterfaces adminInterfaces) : base(adminInterfaces)
        {
        }

        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            try
            {
                if(await _adminInterfaces.clienteRepository.Validate(cliente.telefono))
                {
                    throw new InvalidOperationException("Ya existe un cliente registrado hoy con ese teléfono.");
                }

                return await _adminInterfaces.clienteRepository.Add(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Cliente>> GetAll(DateTime? fecha)
        {
            try
            {
               return await _adminInterfaces.clienteRepository.GetAllFilter(fecha);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
