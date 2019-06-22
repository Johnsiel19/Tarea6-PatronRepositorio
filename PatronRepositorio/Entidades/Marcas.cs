using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Marcas
    {
        [Key]
        public int MarcaId { get; set; }
        public string Nombre { get; set; }

        public Marcas()
        {
            this.MarcaId = 0;
            this.Nombre = string.Empty;

        }
    }
}
