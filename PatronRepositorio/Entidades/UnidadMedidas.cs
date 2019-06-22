using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class UnidadMedidas
    {
        [Key]
        public int UnidadMedidaId { get; set; }
        public string Nombre { get; set; }

        public UnidadMedidas()
        {
            UnidadMedidaId = 0;
            Nombre = string.Empty;
        }

    }
}
