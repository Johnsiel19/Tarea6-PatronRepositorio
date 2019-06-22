using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Cargos
    {
        [Key]
        public int CargoId { get; set; }
        public string Nombre { get; set; }
        public int EstadoId { get; set; }

        public Cargos()
        {
            CargoId = 0;
            Nombre = string.Empty;
            EstadoId = 0;
        }
    }
}
