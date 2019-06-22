using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace CategoriasTests
{
    [TestClass()]
    public class CategoriasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Categorias categorias = new Categorias()
            {
                CategoriaId = 0,
                Nombre = "adida",
                Descripcion = "123",
            };

            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            bool paso = false;
            paso = repositorio.Guardar(categorias);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            bool paso = false;
            Categorias categorias = repositorio.Buscar(1);
            categorias.Nombre = "nike";
            categorias.Descripcion = "h1234";
            paso = repositorio.Modificar(categorias);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categorias = repositorio.Buscar(1);
            Assert.IsNotNull(categorias);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            List<Categorias> lista = new List<Categorias>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

    }
}