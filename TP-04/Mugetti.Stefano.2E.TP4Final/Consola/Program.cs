using Entidades;
using System;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                if (Liga.HarcodeoDatos())
                    Console.WriteLine("Harcodeo ejecutado");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Equipo equipo = new Equipo("Prueba", 11111111, 1998);
            Jugador jdr = new Jugador("pepe", "peposo", 18, 1.85, 65.6, "Argentina", "Izquierdo", "Prueba", 50000000, "Defensa", 44000999);

            #region AgregarJdrYEq

            try
            {
                if (Liga.AgregarEquipo(equipo))
                {
                    DBConnection.InsertarEquipo(equipo.Nombre, equipo.Valor, equipo.AñoCreacion);
                    Console.WriteLine("Equipo agregado a la DB y a la liga");
                }

                Console.WriteLine();

                if (equipo.AgregarJugador(jdr) && Validaciones.DniValido(jdr.Dni))
                {
                    Console.WriteLine("Dni valido, agregando...");
                    DBConnection.InsertarJugador(jdr.Nombre, jdr.Apellido, jdr.Edad, jdr.Altura, jdr.Peso, jdr.Nacionalidad, jdr.PieHabil, jdr.Club, jdr.Valor, jdr.Posicion, jdr.Dni);
                    Console.WriteLine("Jugador agregado a la DB y al equipo");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            #endregion

            if (!Liga.EquipoRepetido("pepsi"))
                Console.WriteLine("El equipo pepsi no existe en la liga\n");


            Console.WriteLine($"El jugador es {Equipo.BuscarJdrPorDni("44000999").Apellido}");

            Console.WriteLine();

            #region BajaJdrsOEquipos

            if (equipo.EliminarJugador(jdr))
            {
                DBConnection.EliminarJugador(jdr.Dni);
                Console.WriteLine("Jugador eliminado del equipo y de la DB\n");

            }

            Console.WriteLine();


            if (Liga.EliminarEquipo(equipo))
            {
                DBConnection.EliminarEquipo(equipo.Nombre);
                Console.WriteLine("Equipo eliminado de la liga y de la DB");
            }

            Console.WriteLine();

            #endregion
          
            if (Liga.ObtenerEquipo("noexiste") == null)
                Console.WriteLine("El equipo no existe\n");

            Console.WriteLine();

            try
            {
                List<Jugador> jdrs = DBConnection.ConsultaJugadores("SELECT * FROM JUGADORES");
                Console.WriteLine($"La cantidad de equipos es :{Liga.ObtenerLista().Count}");
                Console.WriteLine($"La cantidad de jugadore es :{Equipo.ObtenerTodosLosJugadores().Count}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Fallo la consulta:" + $"{ex.Message}");
            }
        }
    }
}
