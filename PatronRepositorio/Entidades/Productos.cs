using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Productos
    {

        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public double CostoCompra { get; set; }
        public double Stock { get; set; }
        public int UnidadMedidaId { get; set; }
        public int ImagenId { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }

        public Productos()
        {
            this.ProductoId = 0;
            this.Nombre = string.Empty;
            this.Descripcion = string.Empty;
            this.FechaFabricacion = DateTime.Now;
            this.CostoCompra = 0;
            this.Stock = 0;
            this.UnidadMedidaId = 0;
            this.ImagenId = 0;
            this.CategoriaId = 0;
            this.MarcaId = 0;
            this.ModeloId = 0;
        }

    }
}
