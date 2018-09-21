using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Categoria")]
    public  class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNombre { get; set; }
        public string UsuarioGestion { get; set; }

        public virtual ICollection<Subcategoria> Subcategoria { get; set; }
    }
}
