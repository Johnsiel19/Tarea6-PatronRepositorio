using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;

namespace ImagenesTest
{
    [TestClass()]
    public class ImagenesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Imagenes imagenes = new Imagenes()
            {
       
                RutaImagen = "Main"
            };

            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            paso = repositorio.Guardar(imagenes);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            Imagenes imagenes = repositorio.Buscar(1);
            imagenes.RutaImagen = "Second";
            paso = repositorio.Modificar(imagenes);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            Imagenes imagenes = repositorio.Buscar(1);
            Assert.IsNotNull(imagenes);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            List<Imagenes> lista = new List<Imagenes>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

    }
}