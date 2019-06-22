using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.Entidades;


namespace VentasTest
{
    [TestClass()]
    public class VentasTest
    {
        [TestMethod()]

        public void GuardarTest()
        {
            Ventas ventas = new Ventas()
            {
                Igv = 3,
                SubTotal = 1,
                CostoVenta = 1,
                UsuarioId = 1,
                ClienteId = 9,
                TipoComprobanteId = 4,
                FechaVenta = DateTime.Now,
               
            };
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            paso = repositorio.Guardar(ventas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            Ventas ventas = repositorio.Buscar(1);
            ventas.UsuarioId = 2;
            ventas.Igv = 3;
            ventas.SubTotal = 7;
            ventas.CostoVenta = 2;

            paso = repositorio.Modificar(ventas);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            Ventas ventas = repositorio.Buscar(1);
            Assert.IsNotNull(ventas);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            List<Ventas> lista = new List<Ventas>();
            lista = repositorio.GetList(v => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}