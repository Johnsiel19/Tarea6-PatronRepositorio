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
    public class EmpleadosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Empleados empleados = new Empleados()
            {

               
                EstadoId = 1,
                CargoId = 1,
                PersonaId = 1
            };

            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            bool paso = false;
            paso = repositorio.Guardar(empleados);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Empleados> db = new RepositorioBase<Empleados>();

            Empleados empleados = new Empleados()
            {
                EmpleadoId = 1,
                EstadoId = 2,
               CargoId = 3,
                PersonaId = 1
            };

            Assert.IsTrue(db.Modificar(empleados));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            Empleados empleados = repositorio.Buscar(1);
            Assert.IsNotNull(empleados);
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            List<Empleados> lista = new List<Empleados>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }


        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}