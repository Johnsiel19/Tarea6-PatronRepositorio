using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace MarcasTest
{
    [TestClass()]
    public class MarcasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Marcas marcas = new Marcas()
            {
           
                Nombre = "Nike"
            };
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            paso = repositorio.Guardar(marcas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            Marcas marcas = repositorio.Buscar(1);
            marcas.Nombre = "Jordan";
            paso = repositorio.Modificar(marcas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            Marcas marcas = repositorio.Buscar(1);
            Assert.IsNotNull(marcas);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            List<Marcas> lista = new List<Marcas>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}