using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace UnidadMedidasTest
{
    [TestClass()]
    public class UnidadMedidasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            UnidadMedidas unidad = new UnidadMedidas()
            {

                Nombre = "Kilo"
            };

            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            bool paso = false;
            paso = repositorio.Guardar(unidad);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            bool paso = false;
            UnidadMedidas unidad = repositorio.Buscar(1);
            unidad.Nombre = "Libra";
            paso = repositorio.Modificar(unidad);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            UnidadMedidas unidad = repositorio.Buscar(1);
            Assert.IsNotNull(unidad);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            List<UnidadMedidas> lista = new List<UnidadMedidas>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}