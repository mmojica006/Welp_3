using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("IncSolicEstadoHistorico")]
   public  class IncSolicEstadoHistorico
    {
        public int Id { get; set; }
        public int IncidenteSolicitudId { get; set; }
        public Estado Estado { get; set; }
        public int EstadoId { get; set; }
        public DateTime FechaHoraEstado { get; set; }
        public string ComentariosEstado { get; set; }
        public string UsuarioGestion { get; set; }



    }
}
