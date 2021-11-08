using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestEntidades
{
    [TestClass]
    public class FuncionalidadTest
    {
        /// <summary>
        /// EJECUTAR LOS TEST DE MANERA SINGULAR. (UNO POR UNO PARA EVITAR FALLAS)
        /// </summary>
        Equipo equipoPrueba;
        Jugador jugadorPrueba;
        [TestInitialize]
        public void Initialize()
        {
            Liga.Harcodeo();
            equipoPrueba = new Equipo();
            jugadorPrueba = new Jugador();
        }

        [TestMethod]
        public void Harcodeo_Test()
        {           
            Assert.IsTrue(Equipo.ObtenerTodosLosJugadores().Count == 62);
            Assert.IsTrue(Liga.ObtenerLista().Count == 5);
        } 
        
        [TestMethod]
        public void ABM_Test()
        {           
            Assert.IsTrue(Liga.EliminarEquipo(Liga.ObtenerEquipo("boca")));
            Assert.IsTrue(Liga.AgregarEquipo(equipoPrueba));
            Assert.IsTrue(equipoPrueba.AgregarJugador(jugadorPrueba));
            Assert.IsTrue(equipoPrueba.EliminarJugador(jugadorPrueba));                      
        }

        [TestMethod]
        public void BuscarJugador_Test()
        {
            Assert.IsNull(Equipo.BuscarJdrPorDni(null));
            Assert.IsFalse(Equipo.BuscarJdrPorDni("asd") != null);
            Assert.IsNotNull(Equipo.BuscarJdrPorDni("44320339"));
            Assert.AreEqual(Equipo.BuscarJdrPorDni(""), null);
        }
        [TestMethod]
        public void BuscarEquipo_Test()
        {
            Assert.IsNull(Liga.ObtenerEquipo(null));
            Assert.IsFalse(Liga.ObtenerEquipo("asd") != null);
            Assert.IsNotNull(Liga.ObtenerEquipo("boca"));
            Assert.AreEqual(Liga.ObtenerEquipo(""), null);
        }
        [TestMethod]
        public void ValidarDNI_Test()
        {
            Assert.IsTrue(Validaciones.DniValido(44320339));
            Assert.IsFalse(Validaciones.DniValido(0));
            Assert.IsFalse(Validaciones.DniValido(011111111111111));
        }
    }
}
