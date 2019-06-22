using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Modelos
    {
        [Key]
        public int ModeloId { get; set; }
        public string Nombre { get; set; }

        public Modelos()
        {
            ModeloId = 0;
            Nombre = string.Empty;
        }
    }
}
