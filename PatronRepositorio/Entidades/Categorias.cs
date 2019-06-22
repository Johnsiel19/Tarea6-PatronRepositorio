using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }
    }
}
