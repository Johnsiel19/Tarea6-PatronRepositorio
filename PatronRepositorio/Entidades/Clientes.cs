using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set;  }
        public string Telefono { get; set; }
        public int PersonaId { get; set; }
        public int EstadoId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            PersonaId = 0;
            EstadoId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            FechaCreacion = DateTime.Now;
        }
    }
}
