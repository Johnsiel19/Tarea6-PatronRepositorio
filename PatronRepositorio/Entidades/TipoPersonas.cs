using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class TipoPersonas
    {
        [Key]
        public int TipoPersonaId { get; set; }

        public string Nombre { get; set; }

        public TipoPersonas()
        {
            TipoPersonaId = 0;

            Nombre = string.Empty;
        }
    }
}
