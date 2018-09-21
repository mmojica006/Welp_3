using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("TipoTicket")]
    public class TipoTicket
    {
        public int TipoTicketId { get; set; }
        public string Descripcion { get; set; }
    }
}
