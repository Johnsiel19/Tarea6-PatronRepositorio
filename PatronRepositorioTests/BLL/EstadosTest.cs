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
    public class EstadosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            Estados estados = new Estados()
            {
                
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now,
                Estado = "bien"
            };

            paso = repositorio.Guardar(estados);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            Estados estados = repositorio.Buscar(1);
            estados.FechaFin = DateTime.Now;
            estados.Estado = "Mal";

            paso = repositorio.Modificar(estados);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            Estados estados = repositorio.Buscar(1);
            Assert.IsNotNull(estados);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            List<Estados> lista = new List<Estados>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }


}