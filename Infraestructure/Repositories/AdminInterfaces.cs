using Core.Interfaces.Repository;
using Persistence.ContextEntity;
namespace Infraestructure.Repositories
{
    public class AdminInterfaces(PruTecContext context) : IAdminInterfaces
    {
        private readonly IClienteRepository _clienteRepository;
        public IClienteRepository clienteRepository => _clienteRepository ?? new ClienteRepository(context);

        private readonly IMotivoRepository _motivoRepository;
        public IMotivoRepository motivoRepository => _motivoRepository ?? new MotivoRepository(context);        

        public void Dispose()
        {
            if (context != null) {
                context.Dispose();  
            }
        }
    }
}
