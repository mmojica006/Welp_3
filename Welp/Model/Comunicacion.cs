using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Comunicacion")]
    public class Comunicacion
    {
        public int ComunicacionId { get; set; }
        public IncidenteSolicitud IncidenteSolicitud { get; set; }
        public int IncidenteSolicitudId { get; set; }
        public string Remitente { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        
        [DefaultValue("false")]
        public bool Leido { get; set; }
        public DateTime FechaLectura { get; set; }
        public string UsuarioGestion { get; set; }


    }
}
