using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Motivo : BaseEntity
    {
        public string nombreMotivo { get; set; }
        public virtual ICollection<Cliente> cliente { get; set; }   
    }
}
