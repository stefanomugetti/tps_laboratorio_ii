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
                if(Liga.Harcodeo())
                    Console.WriteLine("Harcodeo ejecutado");
            }
            catch (DniException e)
            {
                Console.WriteLine(e.Message);
            }

            Equipo equipo = new Equipo("Prueba", 11111111, 1998);
            Equipo equipo1 = new Equipo("Prueba", 11111111, 1998);
            Jugador jdr = new Jugador("pepe","peposo",18,1.85,65.6,"Argentina","Izquierdo","Prueba",50000000,"Defensa",44000999);
            Jugador jdr1 = new Jugador("pepito","ppaas",18,1.85,65.6,"Argentina","Izquierdo","Prueba",50000000,"Defensa",12345678);

            if(Liga.AgregarEquipo(equipo))
                Console.WriteLine("Equipo agregado\n");

            if(Liga.EquipoRepetido("PrUeBa"))
                Console.WriteLine("El equipo esta repetido\n");

            if(equipo.AgregarJugador(jdr) &&
                equipo.AgregarJugador(jdr1))           
                Console.WriteLine("Jugadores agregados\n");
            Console.WriteLine(equipo.Jugadores.Count+"\n");

            jdr.Apellido = "Modif";

                Console.WriteLine(Equipo.BuscarJdrPorDni("44000999").Apellido+"\n");

            if(equipo.EliminarJugador(jdr))
                Console.WriteLine("Jugador eliminado\n");
            Console.WriteLine(equipo.Jugadores.Count);
            
            if(!equipo.EliminarJugador(new Jugador()))
                Console.WriteLine("Jugador no existe en el equipo\n");

            if(Liga.EliminarEquipo(equipo))
                Console.WriteLine("Equipo eliminador\n");

            if(Liga.ObtenerEquipo("Prueba") == null)
                Console.WriteLine("El equipo no existe\n");

            Equipo obtenerEquipo = Liga.ObtenerEquipo("pRueBa");
            if(obtenerEquipo != null)
                Console.WriteLine($"Existe el equipo {obtenerEquipo.Nombre}");

            jdr1.Mostrar();







            //Archivos<Jugador>.SerializeXML(Equipo.ObtenerTodosLosJugadores());
           


        }
    }
}
