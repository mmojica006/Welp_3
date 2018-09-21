using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Estado")]
    public class Estado
    {
     
        public int EstadoId { get; set; }
        public string NombreEstado { get; set; }
        public string DescripcionEstado { get; set; }
        public string Abreviatura { get; set; }
        public string  UsuarioGestion { get; set; }

    }
}
