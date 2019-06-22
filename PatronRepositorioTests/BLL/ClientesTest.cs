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
    public class ClientesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();


            Clientes tipos = new Clientes()
            {

                PersonaId = 1,
                EstadoId = 1,
                Nombre = "John",
                Telefono = "225425",
                FechaCreacion = DateTime.Now
            };
            Assert.IsTrue(db.Guardar(tipos));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Clientes clientes = new Clientes()
            {
                ClienteId = 1,
                EstadoId= 1,
                Nombre = "Johnss",
                Telefono = "225425225",
                PersonaId = 1,
                FechaCreacion = DateTime.Now
            };

            Assert.IsTrue(db.Modificar(clientes));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}