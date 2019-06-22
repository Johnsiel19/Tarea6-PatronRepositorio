using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public int EmpleadoId { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            EmpleadoId = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
        }
    }
}