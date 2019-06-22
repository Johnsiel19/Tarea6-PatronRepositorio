using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.BLL;
using PatronRepositorio.DAL;



namespace PatronRepositorio.BLL.RepositorioBase.Tests
{
    [TestClass()]
    public class PersonasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {

            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Personas personas = new Personas();

     
            personas.Dni = 1;
            personas.Nombre = "john";
            personas.Materno = "juan";
            personas.Paterno = "castillo";
            personas.FechaNacimiento = DateTime.Now;
            personas.Telefono = "22222222";
            personas.Correo = "fgsdfss";
            personas.Sexo = "f";
            personas.ImagenId = 2;
            personas.Direccion = "sfm";
            personas.TipoPersonaId = 1;

            RepositorioBase<Personas> repositorio = new RepositorioBase<Personas>();
            bool paso = false;
            paso = repositorio.Guardar(personas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {

            RepositorioBase<Personas> db = new RepositorioBase<Personas>();
            Personas persona = new Personas()
            {
                PersonaId = 1,
                Dni = 1,
                Nombre = "john",
                Materno = "joe",
                Paterno = "manuel",
                FechaNacimiento = DateTime.Now,
                Telefono = "2515",
                Correo = "5282",
                Sexo = "M",
                Direccion = "addewwe",
                TipoPersonaId = 1
            };

            Assert.IsTrue(db.Modificar(persona));
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
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.GetList(p => true));

        }
        
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsTrue(db.Eliminar(1));
        }



    }
}