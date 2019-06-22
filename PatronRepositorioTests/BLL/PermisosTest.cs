using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace PatronRepositorio.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Permisos permisos = new Permisos()
            {
              
                Descripcion = "junior",
                Funcionalidad = "nothing"
            };

            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            paso = repositorio.Guardar(permisos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            Permisos permisos = repositorio.Buscar(1);
            permisos.Descripcion = " no";
            paso = repositorio.Modificar(permisos);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            Permisos permisos = repositorio.Buscar(1);
            Assert.IsNotNull(permisos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            List<Permisos> lista = new List<Permisos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }


        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}