using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Subcategoria")]
    public  class Subcategoria
    {
        public int SubcategoriaId { get; set; }
        public string SubcategoriaNombre { get; set; }
        public string UsuarioGestion { get; set; }

        public int? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<IncidenteSolicitud> IncidenteSolicitud { get; set; }
    }
}
