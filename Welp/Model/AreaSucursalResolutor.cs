using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("AreaSucursalResolutor")]
    public class AreaSucursalResolutor
    {
        public int AreaSucursalResolutorId { get; set; }

        public int ResolutorId { get; set; }
        public Resolutor Resolutor { get; set; }

        public int AreaSucursalId { get; set; }
        public AreaSucursal AreaSucursal { get; set; }
    }
}
