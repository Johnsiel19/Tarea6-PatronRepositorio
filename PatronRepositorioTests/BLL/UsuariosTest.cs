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
    public class UsuariosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios usuarios = new Usuarios()
            {
                UsuarioId = 1,
                EmpleadoId = 6,
                Usuario = "jose",
                Clave = "contra"
            };

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            bool paso = false;
            paso = repositorio.Guardar(usuarios);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            bool paso = false;
            Usuarios usuarios = repositorio.Buscar(1);
            usuarios.Usuario = "john";
            usuarios.Clave = "123";
            paso = repositorio.Modificar(usuarios);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = repositorio.Buscar(1);
            Assert.IsNotNull(usuarios);
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> lista = new List<Usuarios>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}