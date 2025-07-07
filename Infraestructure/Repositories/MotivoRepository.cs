using Core.Entities;
using Core.Interfaces.Repository;
using Persistence.ContextEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class MotivoRepository : BaseRepository<Motivo>, IMotivoRepository
    {
        public MotivoRepository(PruTecContext context) : base(context)
        {
        }
    }
}
