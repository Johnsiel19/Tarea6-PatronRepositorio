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
    public class Usuarios_Has_PermitidoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios_Has_Permisos usuarios = new Usuarios_Has_Permisos()
            {
           
                PermisoId = 1
            };

            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            bool paso = false;
            paso = repositorio.Guardar(usuarios);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            bool paso = false;
            Usuarios_Has_Permisos usuarios = repositorio.Buscar(1);
            usuarios.PermisoId = 5;
            paso = repositorio.Modificar(usuarios);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            Usuarios_Has_Permisos usuarios = repositorio.Buscar(1);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            List<Usuarios_Has_Permisos> lista = new List<Usuarios_Has_Permisos>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}