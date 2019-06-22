using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace ComrasTests
{
    [TestClass()]
    public class ComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Compras compras = new Compras()
            {
                CompraId = 1,
                UsuarioId = 6,
                ProveedorId = 2,
                ComprobanteId = 3,
                CostoCompra = 8,
                FechaCompra = DateTime.Now,
            };
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            bool paso = false;
            paso = repositorio.Guardar(compras);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            bool paso = false;
            Compras compras = repositorio.Buscar(1);
            compras.UsuarioId = 1;
            compras.ProveedorId = 0;
            paso = repositorio.Modificar(compras);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            Compras compras = repositorio.Buscar(1);
            Assert.IsNotNull(compras);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            List<Compras> lista = new List<Compras>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}