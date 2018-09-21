using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Adjuntos")]
    public class Adjuntos
    {
        public int AdjuntosId { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public string Nombrearchivo { get; set; }
        public string TipoArchivo { get; set; }
        public string Archivo { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string UsuarioGestion { get; set; }

    }
}
