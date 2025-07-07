using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        public int idMotivo { get; set; }  
        public string nombres { get; set; }  
        public string apellidos { get; set; }  
        public string telefono { get; set; }  
        public bool sexo { get; set; }  
        public DateTime fecha { get; set; }  

        public virtual Motivo idMotivoNavigator { get; set; }    

    }
}
