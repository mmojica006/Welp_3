using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("IncidenteSolicitud")]
   public  class IncidenteSolicitud
    {
        public int IncidenteSolicitudId { get; set; }
        public int? SubcategoriaId { get; set; }
        public virtual Subcategoria Subcategoria { get; set; }

        public string PersonaSoporte { get; set; }
        public string PersonaAsignacion { get; set; }
        public DateTime FechaAsignacion { get; set; }

        public Estado Estado { get; set; }
        public int EstadoId { get; set; }

        public DateTime FechaFinalizacionEstimada { get; set; }
        public DateTime FechaSolucion { get; set; }
        public string SolucionAplicada { get; set; }
        public int Rating { get; set; }
        public string MotivoRetraso { get; set; }
        public string UsuarioGestion { get; set; }


    }
}
