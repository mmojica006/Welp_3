using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Ticket")]
    public class Ticket
    {
        public int TicketId { get; set; }
        public int? SubcategoriaId { get; set; }
        public virtual Subcategoria Subcategoria { get; set; }

        public string Encabezado { get; set; }
        public string Prioridad { get; set; }
        public string DescripcionPeticion { get; set; }
        public DateTime FechaEntradaTicket { get; set; }
        public string UsuarioPeticion { get; set; }
        public int TipoTicketId { get; set; }
        public TipoTicket TipoTicket { get; set; }
        public string archivosURL { get; set; }
        public bool TieneAdjuntos { get; set; }
        [DefaultValue("false")]
        public bool Eliminado { get; set; }
        public string UsuarioGestion { get; set; }

        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }




    }
}
