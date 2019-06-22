using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace ProductosTest
{
    [TestClass()]
    public class ProductosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Productos productos = new Productos()
            {
                Nombre = "Cebolla",
                Descripcion = "Entera",
                UnidadMedidaId = 2,
                ImagenId = 14,
                CategoriaId = 8,
                MarcaId = 7,
                ModeloId = 7,
                FechaFabricacion = DateTime.Now,
                CostoCompra = 1,
                Stock = 1,
           
            };

            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            paso = repositorio.Guardar(productos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            Productos productos = repositorio.Buscar(1);
            productos.Descripcion = "Enteras";
            productos.Nombre = "Cebollas";
            paso = repositorio.Modificar(productos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = repositorio.Buscar(1);
            Assert.IsNotNull(productos);
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            List<Productos> lista = new List<Productos>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}