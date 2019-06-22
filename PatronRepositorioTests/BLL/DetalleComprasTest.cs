using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace VentaDetallesTest
{
    [TestClass()]
    public class VentaDetallesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            DetalleCompras tipos = new DetalleCompras()
            {
                
                CompraId = 7,
                ProductoId = 3,
                Unidades = 1,
                CostoUnidad = 1,
                Total = 10
            };

            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            paso = repositorio.Guardar(tipos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            DetalleCompras detalle = repositorio.Buscar(1);
            detalle.CompraId = 8;
            paso = repositorio.Modificar(detalle);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            DetalleCompras detalle = repositorio.Buscar(1);
            Assert.IsNotNull(detalle);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            List<DetalleCompras> lista = new List<DetalleCompras>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}