using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace ModelosTest
{
    [TestClass()]
    public class ModelosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Modelos modelos = new Modelos()
            {
                Nombre = "LS2"
            };
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            bool paso = false;
            paso = repositorio.Guardar(modelos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            bool paso = false;
            Modelos modelos = repositorio.Buscar(1);
            modelos.Nombre = "L4S";
            paso = repositorio.Modificar(modelos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            Modelos modelos = repositorio.Buscar(1);
            Assert.IsNotNull(modelos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            List<Modelos> lista = new List<Modelos>();
            lista = repositorio.GetList(m => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}