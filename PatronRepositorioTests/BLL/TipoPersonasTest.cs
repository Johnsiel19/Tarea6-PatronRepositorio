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
    public class TipoPersonasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();


            TipoPersonas tipoPersona = new TipoPersonas()
            {

                Nombre = "David"
            };
            Assert.IsTrue(db.Guardar(tipoPersona));

        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();
            TipoPersonas tipoPersona = new TipoPersonas()
            {
                TipoPersonaId = 1,
                Nombre = "Johnsiel"
            };

            Assert.IsTrue(db.Modificar(tipoPersona));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();

            Assert.IsNotNull(db.GetList(t => true));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}