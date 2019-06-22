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
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Usuarios_Has_Permisos> Usuarios_Has_Permitido { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<DetalleCompras> DetalleCompras { get; set; }
        public DbSet<DetalleVentas> DetalleVentas { get; set; }
        public DbSet<Imagenes> Imagenes { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<UnidadMedidas> UnidadMedidas { get; set; }
        public DbSet<TiposComprobantes> Comprobantes { get; set; }


        public Contexto() : base("ConStr")
        { }
    }
}
