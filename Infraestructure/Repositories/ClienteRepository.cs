using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.ContextEntity;

namespace Infraestructure.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(PruTecContext context) : base(context)
        {
        }

        public async Task<List<Cliente>> GetAllFilter(DateTime? fecha)
        {
            try
            {
                var query = _entities.AsQueryable();

                if (fecha.HasValue)
                {
                    query = query.Include(x => x.idMotivoNavigator).Where(x => x.fecha == fecha.Value);
                }

                return await query.ToListAsync();
            }
            catch (Exception)
            {
                throw; 
            }
        }

        public async Task<bool> Validate(string telefono)
        {
            try
            {
                var hoy = DateTime.Today;
                var mañana = hoy.AddDays(1);

                return await _entities.AnyAsync(x =>
                    x.telefono == telefono &&
                    x.fecha >= hoy &&
                    x.fecha < mañana);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
