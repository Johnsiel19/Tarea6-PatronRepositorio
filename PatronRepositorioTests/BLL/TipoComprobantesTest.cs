using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoComprovantessTest
{
    [TestClass()]
    public class TipoComprobantesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TiposComprobantes tipos = new TiposComprobantes()
            {
        
                Nombre = "Ordinario"
            };

            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            bool paso = false;
            paso = repositorio.Guardar(tipos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            bool paso = false;
            TiposComprobantes tipos = repositorio.Buscar(1);
            tipos.Nombre = "Normal";
            paso = repositorio.Modificar(tipos);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            TiposComprobantes tipos = repositorio.Buscar(1);
            Assert.IsNotNull(tipos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            List<TiposComprobantes> lista = new List<TiposComprobantes>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

    }
}