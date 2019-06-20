﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Personas
    {

            [Key]
            public int IdPersona { get; set; }
            public int Dni { get; set; }
            public string Nombre { get; set; }
            public string Matemo { get; set; }
            public string Paterno { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Telefonon { get; set; }
            public string Correo { get; set; }
            public char Sexo { get; set; }
            public int IdImagen { get; set; }
            public string Direccion { get; set; }
            public int IdTipoPersona { get; set; }

        

    }
}
