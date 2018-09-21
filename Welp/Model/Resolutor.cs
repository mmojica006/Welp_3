using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Resolutor")]
    public class Resolutor
    {
        public int ResolutorId { get; set; }
        public string ApellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }        
        public string Nombres { get; set; }
        public string NombreUsuario { get; set; }
        public string UsuarioGestion { get; set; }
    }
}
