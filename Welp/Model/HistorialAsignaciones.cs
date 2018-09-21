using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("HistorialAsignaciones")]
    public  class HistorialAsignaciones
    {
        public int HistorialAsignacionesId { get; set; }

        public int IncidenteSolicitudId { get; set; }
        public IncidenteSolicitud IncidenteSolicitud { get; set; }
        public string PersonaSoporte { get; set; }
        public string MotivoReasignacion  { get; set; }
        public DateTime FechaReasignacion { get; set; }
        public string PersonaRealizaReasignacion { get; set; }
        public string UsuarioGestion { get; set; }

    }
}
