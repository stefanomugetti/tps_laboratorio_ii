using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestEntidades
{
    [TestClass]
    public class FuncionalidadTest
    {
        Equipo equipoPrueba;
        Jugador jugadorPrueba;

        [TestInitialize]
        public void Initialize()
        {
            Liga.HarcodeoDatos();
            equipoPrueba = new Equipo();
            jugadorPrueba = new Jugador();
        }
        
        [TestMethod]
        public void BuscarEquipo_Test()
        {
            Equipo equipo = Liga.ObtenerEquipo(null);
            Assert.IsNull(equipo);        
        }
        [TestMethod]
        public void ABM_Test()
        {           
            Assert.IsTrue(Liga.AgregarEquipo(equipoPrueba));
            Assert.IsTrue(equipoPrueba.AgregarJugador(jugadorPrueba));
            Assert.IsTrue(equipoPrueba.EliminarJugador(jugadorPrueba));       
        }

        [TestMethod]
        public void BuscarJugador_Test()
        {
            Jugador jdr = Equipo.BuscarJdrPorDni(null);
            Assert.IsNull(jdr);
        }
        [TestMethod]
        public void ValidarDNI_Test()
        {
            bool dniValido = Validaciones.DniValido(0);

            Assert.IsFalse(dniValido);
        } 
        
        [TestMethod]
        public void DataBaseJugadores_Test()
        {
            List<Jugador> jdr = DBConnection.ConsultaJugadores("SELECT * FROM JUGADORES");
                        
            Assert.IsNotNull(jdr);
        }
        
        [TestMethod]
        public void DataBaseEquipos_Test()
        {
            List<Equipo> equipos = DBConnection.ConsultaEquipos("SELECT * FROM EQUIPOS");

            Assert.IsNotNull(equipos);
        }
    }
}
