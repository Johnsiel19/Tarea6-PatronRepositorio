using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Estados
    {
        [Key]
        public int EstadoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }

        public Estados()
        {
            EstadoId = 0;
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
            Estado = string.Empty;
        }
    }
}