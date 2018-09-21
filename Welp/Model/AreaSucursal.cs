using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("AreaSucursal")]
    public class AreaSucursal
    {
        public int AreaSucursalId { get; set; }
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }


    }
}
