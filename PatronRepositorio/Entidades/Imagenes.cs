using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Imagenes
    {
        [Key]
        public int ImagenId { get; set; }
        public string RutaImagen { get; set; }

        public Imagenes()
        {
            ImagenId = 0;
            RutaImagen = string.Empty;
        }
    }
}
