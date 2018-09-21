using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Area")]
   public  class Area
    {
        public int AreaId { get; set; }
        public string NnombreArea { get; set; }
        public string Descripcion { get; set; }
        public int orden { get; set; }
        
    }
}
