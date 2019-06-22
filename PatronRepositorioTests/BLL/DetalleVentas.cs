using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace DetalleCompraTest
{
    [TestClass()]
    public class DetallesCompraTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            DetalleVentas tipos = new DetalleVentas()
            {
                
                VentaId = 7,
                ProductoId = 0,
                Unidades = 1,
                CostoUnidad = 0,
                DescuentoUnidad = 4,
                Total = 10
            };

            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            paso = repositorio.Guardar(tipos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            DetalleVentas detalle = repositorio.Buscar(1);
            detalle.VentaId = 2;
            paso = repositorio.Modificar(detalle);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            DetalleVentas detalle = repositorio.Buscar(1);
            Assert.IsNotNull(detalle);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            List<DetalleVentas> lista = new List<DetalleVentas>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}