using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Proveedores
    {
        [Key]
        public int ProveerdorId { get; set; }
        public int PersonaId { get; set; }

        public Proveedores()
        {
            ProveerdorId = 0;
            PersonaId = 0;
        }
    }
}
