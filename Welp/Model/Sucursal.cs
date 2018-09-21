using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Sucursal")]
    public class Sucursal
    {
        public int SucursalId { get; set; }
        public string NombreSucursal { get; set; }


    }
}
