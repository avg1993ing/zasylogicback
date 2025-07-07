using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public int idMotivo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public bool sexo { get; set; }
        public DateTime fecha { get; set; }
        public MotivoDto MotivoDto { get; set; }    
    }
}
