using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PatronRepositorio.Entidades;

namespace PatronRepositorio.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        
        public DbSet<TipoPersonas> TipoPersonas { get; set; }


        public Contexto() : base("ConStr")
        { }
    }
}
