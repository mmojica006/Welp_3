using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Correlacion")]
    public class Correlacion
    {
        public int CorrelacionId { get; set; }
        public string Descripcion { get; set; }
        public string UsuarioGestion { get; set; }
    }
}
