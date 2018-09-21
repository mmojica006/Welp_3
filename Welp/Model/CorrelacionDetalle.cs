using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("CorrelacionDetalle")]
    public class CorrelacionDetalle
    {
        public int CorrelacionDetalleId { get; set; }
        public Correlacion Correlacion { get; set; }
        public int CorrelacionId { get; set; }
        public IncidenteSolicitud IncidenteSolicitud { get; set; }
       public int IncidenteSolicitudId { get; set; }
        public string UsuarioGestion { get; set; }


    }
}
