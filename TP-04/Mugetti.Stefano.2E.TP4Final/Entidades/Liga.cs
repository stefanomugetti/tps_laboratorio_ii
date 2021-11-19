using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public static class Liga
    {
        static string nombre;
        static List<Equipo> equipos;

        public static string Nombre { get => nombre; set => nombre = value; }
        public static List<Equipo> Equipos { get => equipos; set => equipos = value; }

        static Liga()
        {
            Nombre = "Liga Argentina de Futbol";
            equipos = new List<Equipo>();
        }

        public static List<Equipo> ObtenerLista()
        {
            return equipos;
        }
        /// <summary>
        /// Agrega un equipo a la lista 
        /// </summary>
        /// <param name="equipo">Equipo a agregar</param>
        /// <returns>retorna false si no lo pudo agregar(repetido) de lo contrario true</returns>
        public static bool AgregarEquipo(Equipo equipo)
        {
            if (!equipos.Contains(equipo))
            {
                equipos.Add(equipo);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que el nombre del equipo no este repetido
        /// </summary>
        /// <param name="equipo">nombre del equipo a validar repeticion</param>
        /// <returns>return true si se repite, de lo contario false</returns>
        public static bool EquipoRepetido(string equipo)
        {
            foreach (Equipo item in equipos)
            {
                if (item.Nombre.ToLower() == equipo.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Obtiene un equipo de la liga segun el nombre
        /// </summary>
        /// <param name="nombre">nombre del equipo a buscar</param>
        /// <returns>return retorna null si no existe, de lo contrario el Equipo</returns>
        public static Equipo ObtenerEquipo(string nombre)
        {
            if (!String.IsNullOrEmpty(nombre))
            {
                foreach (Equipo item in equipos)
                {
                    if (item.Nombre.ToLower() == nombre.ToLower())
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Valida que el dni pasado por parametro no exista en la lista de jugadores 
        /// </summary>
        /// <param name="dni">dni a verificar</param>
        /// <returns>return retorna true si se repeti, de lo contrario false</returns>
        public static bool JugadorRepetido(long dni)
        {
            foreach (Equipo item in equipos)
            {
                List<Jugador> jugadores = item.ObtenerListaJugadores();
                if (jugadores != null)
                {
                    foreach (Jugador jgr in jugadores)
                    {
                        if (jgr.Dni == dni)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Elimina un equipo de la liga
        /// </summary>
        /// <param name="equipo">equipo a eliminar</param>
        /// <returns>return retorna true si lo pudo eliminar de lo contrario false</returns>
        public static bool EliminarEquipo(Equipo equipo)
        {
            if (equipos.Remove(equipo))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Realiza el hardcodeo validando que no se repita la carga de datos
        /// </summary>
        /// <returns></returns>
        /// 
        public static bool Harcodeo()
        {
            Equipo equipo = new Equipo("Boca", 650050000, 1988);

            Jugador jdr = new Jugador("Stefano", "Mugetti", 18, 1.80, 65.4, "Argentina", "Izquierdo", "Boca", 500000000, "Defensa", 44320339);
            Jugador jdr2 = new Jugador("Juan", "Blatter", 29, 1.75, 75.6, "Argentina", "Derecho", "Boca", 6000000, "Delantero", 42322332);
            Jugador jdr3 = new Jugador("Gabriel", "Lopez", 27, 1.93, 77.3, "Argentina", "Derecho", "Boca", 4900500, "Defensa", 45221730);
            Jugador jdr4 = new Jugador("Julio", "Mendez", 26, 1.65, 78.8, "Argentina", "Derecho", "Boca", 1600000, "Mediocampista", 38945762);
            Jugador jdr5 = new Jugador("Thomas", "Folmer", 20, 1.73, 73.3, "Argentina", "Izquierdo", "Boca", 60500000, "Defensa", 36546918);
            Jugador jdr6 = new Jugador("Luis", "Zapata", 18, 1.63, 67.2, "Argentina", "Derecho", "Boca", 100000, "Arquero", 40213649);
            Jugador jdr7 = new Jugador("Leandro", "Leguizamon", 19, 1.74, 66.7, "Argentina", "Derecho", "Boca", 9800000, "Mediocampista", 46792587);
            Jugador jdr8 = new Jugador("Heber", "Martinez", 21, 1.92, 71.3, "Argentina", "Derecho", "Boca", 700000, "Delantero", 35420154);
            Jugador jdr9 = new Jugador("Genaro", "Rios", 19, 1.91, 68.9, "Argentina", "Derecho", "Boca", 65200000, "Defensa", 46578203);
            Jugador jdr10 = new Jugador("Patricio", "Espinoza", 26, 1.84, 80.9, "Argentina", "Izquierdo", "Boca", 9850000, "Mediocampista", 43002052);
            Jugador jdr11 = new Jugador("Fernando", "Maidana", 34, 1.82, 70.3, "Argentina", "Derecho", "Boca", 16005000, "Mediocampista", 42873645);
            Jugador jdrA = new Jugador("Martin", "Canali", 40, 1.92, 80.6, "Bolivia", "Derecho", "Boca", 16025900, "Defensa", 42820745);
            Jugador jdrB = new Jugador("Enzo", "Piñero", 17, 1.68, 65.3, "Argentina", "Derecho", "Boca", 16005000, "Mediocampista", 34157981);

            equipo.AgregarJugador(jdr);
            equipo.AgregarJugador(jdr2);
            equipo.AgregarJugador(jdr3);
            equipo.AgregarJugador(jdr4);
            equipo.AgregarJugador(jdr5);
            equipo.AgregarJugador(jdr6);
            equipo.AgregarJugador(jdr7);
            equipo.AgregarJugador(jdr8);
            equipo.AgregarJugador(jdr9);
            equipo.AgregarJugador(jdr10);
            equipo.AgregarJugador(jdr11);
            equipo.AgregarJugador(jdrA);
            equipo.AgregarJugador(jdrB);


            Equipo equipo2 = new Equipo("River", 600000000, 1958);

            Jugador jdr12 = new Jugador("Agustin", "Rossi", 18, 1.73, 72.3, "Argentina", "Derecho", "River", 14565000, "Mediocampista", 43812345);
            Jugador jdr13 = new Jugador("Felipe", "Zarate", 32, 1.80, 76.3, "Colombia", "Derecho", "River", 17895000, "Arquero", 42874319);
            Jugador jdr14 = new Jugador("Oscar", "Medina", 30, 1.88, 77.4, "Chile", "Derecho", "River", 11325000, "Mediocampista", 42000009);
            Jugador jdr15 = new Jugador("Roberto", "Fornari", 24, 1.83, 69.5, "Ecuador", "Derecho", "River", 35405000, "Delantero", 42876735);
            Jugador jdr16 = new Jugador("Alberto", "Severino", 34, 1.78, 79.7, "España", "Derecho", "River", 98705000, "Delantero", 42015645);
            Jugador jdr17 = new Jugador("Lionel", "Boscovich", 27, 1.65, 81.8, "Colombia", "Derecho", "River", 64505000, "Mediocampista", 40873045);
            Jugador jdr18 = new Jugador("Martin", "Stanley", 34, 1.75, 82.1, "España", "Derecho", "River", 29705000, "Mediocampista", 40070645);
            Jugador jdr19 = new Jugador("Ramiro", "McQueen", 30, 1.92, 70.2, "Italia", "Derecho", "River", 20005000, "Defensa", 40000000);
            Jugador jdr20 = new Jugador("Gonzalo", "Blanes", 23, 1.62, 76.3, "Argentina", "Derecho", "River", 30005000, "Defensa", 32073005);
            Jugador jdr21 = new Jugador("Tomas", "Loleo", 20, 1.82, 72.6, "Colombia", "Derecho", "River", 64005000, "Defensa", 32003205);
            Jugador jdr22 = new Jugador("Mauro", "Klan", 19, 1.72, 67.9, "Argentina", "Derecho", "River", 20005000, "Defensa", 28653645);

            equipo2.AgregarJugador(jdr12);
            equipo2.AgregarJugador(jdr13);
            equipo2.AgregarJugador(jdr14);
            equipo2.AgregarJugador(jdr15);
            equipo2.AgregarJugador(jdr16);
            equipo2.AgregarJugador(jdr17);
            equipo2.AgregarJugador(jdr18);
            equipo2.AgregarJugador(jdr19);
            equipo2.AgregarJugador(jdr20);
            equipo2.AgregarJugador(jdr21);
            equipo2.AgregarJugador(jdr22);



            Equipo equipo3 = new Equipo("Independiente", 50050000, 1998);

            Jugador jdr23 = new Jugador("Mariano", "Mugetti", 19, 1.82, 62.9, "Argentina", "Derecho", "Independiente", 7895000, "Mediocampista", 34653645);
            Jugador jdr24 = new Jugador("Oscar", "Serna", 29, 1.62, 87.9, "Argentina", "Derecho", "Independiente", 20097800, "Mediocampista", 34516645);
            Jugador jdr25 = new Jugador("Cristian", "Riquelme", 37, 1.92, 65.9, "Argelia", "Izquierdo", "Independiente", 30005000, "Mediocampista", 28233645);
            Jugador jdr26 = new Jugador("Mauricio", "Zarate", 18, 1.72, 73.9, "Argentina", "Derecho", "Independiente", 2000500, "Mediocampista", 28600645);
            Jugador jdr27 = new Jugador("Ezequiel", "Fabra", 17, 1.64, 64.8, "Ecuador", "Derecho", "Independiente", 204655000, "Delantero", 27653640);
            Jugador jdr28 = new Jugador("Antonio", "Valencia", 29, 1.74, 65.4, "Argentina", "Derecho", "Independiente", 2000500, "Delantero", 28253000);
            Jugador jdr29 = new Jugador("Frank", "Messi", 26, 1.76, 69.3, "Argentina", "Izquierdo", "Independiente", 20225000, "Delantero", 28343605);
            Jugador jdr30 = new Jugador("Esteban", "Ronaldo", 24, 1.87, 72.2, "Colombia", "Derecho", "Independiente", 3005000, "Defensa", 24853045);
            Jugador jdr31 = new Jugador("Alejandro", "Trojavcich", 32, 1.90, 73.4, "Argentina", "Derecho", "Independiente", 900005000, "Defensa", 28452645);
            Jugador jdr32 = new Jugador("Carlos", "Alvarez", 27, 1.92, 67.1, "Argentina", "Derecho", "Independiente", 40005000, "Defensa", 34623635);
            Jugador jdr33 = new Jugador("Roman", "Cairo", 35, 1.87, 69.0, "Argentina", "Izquierdo", "Independiente", 50005000, "Defensa", 29460045);
            Jugador jdr34 = new Jugador("Enrique", "Ortiz", 25, 1.69, 70.3, "Bolivia", "Derecho", "Independiente", 92005000, "Arquero", 40323642);

            equipo3.AgregarJugador(jdr23);
            equipo3.AgregarJugador(jdr24);
            equipo3.AgregarJugador(jdr25);
            equipo3.AgregarJugador(jdr26);
            equipo3.AgregarJugador(jdr27);
            equipo3.AgregarJugador(jdr28);
            equipo3.AgregarJugador(jdr29);
            equipo3.AgregarJugador(jdr30);
            equipo3.AgregarJugador(jdr31);
            equipo3.AgregarJugador(jdr32);
            equipo3.AgregarJugador(jdr33);
            equipo3.AgregarJugador(jdr34);

            Equipo equipo4 = new Equipo("Huracan", 95000000, 2008);

            Jugador jdr35 = new Jugador("Marcos", "Abreu", 35, 1.84, 80.3, "Bolivia", "Derecho", "Huracan", 920050000, "Defensa", 41323642);
            Jugador jdr36 = new Jugador("Pablo", "Aguilar", 19, 1.92, 70.6, "Argentina", "Derecho", "Huracan", 950050000, "Defensa", 42324316);
            Jugador jdr37 = new Jugador("Nicolas", "Guridi", 20, 1.86, 90.3, "Ecuador", "Derecho", "Huracan", 9200500, "Defensa", 44431672);
            Jugador jdr38 = new Jugador("Ignacio", "Straneo", 24, 1.80, 75.2, "Bolivia", "Derecho", "Huracan", 92325000, "Defensa", 43323642);
            Jugador jdr39 = new Jugador("Juan", "Peña", 27, 1.92, 71.7, "Argentina", "Izquierdo", "Huracan", 82005000, "Mediocampista", 30323642);
            Jugador jdr40 = new Jugador("Douglas", "Rodriguez", 26, 1.69, 73.5, "Bolivia", "Derecho", "Huracan", 72005000, "Mediocampista", 37933642);
            Jugador jdr41 = new Jugador("Felipe", "Ortiz", 35, 1.79, 77.6, "Argentina", "Derecho", "Huracan", 62005000, "Mediocampista", 35134942);
            Jugador jdr42 = new Jugador("Enrique", "Ramirez", 29, 1.60, 70.0, "Argentina", "Izquierdo", "Huracan", 5005000, "Arquero", 30321342);
            Jugador jdr43 = new Jugador("Stefano", "Romero", 30, 1.67, 75.3, "Ecuador", "Derecho", "Huracan", 54005000, "Delantero", 38304642);
            Jugador jdr44 = new Jugador("Oscar", "Romero", 22, 1.64, 80.7, "Bolivia", "Derecho", "Huracan", 23005000, "Delantero", 34320642);
            Jugador jdr45 = new Jugador("Felipe", "Ortiz", 21, 1.61, 85.9, "Argentina", "Derecho", "Huracan", 54005000, "Delantero", 32245642);
            equipo4.AgregarJugador(jdr35);
            equipo4.AgregarJugador(jdr36);
            equipo4.AgregarJugador(jdr37);
            equipo4.AgregarJugador(jdr38);
            equipo4.AgregarJugador(jdr39);
            equipo4.AgregarJugador(jdr40);
            equipo4.AgregarJugador(jdr41);
            equipo4.AgregarJugador(jdr42);
            equipo4.AgregarJugador(jdr43);
            equipo4.AgregarJugador(jdr44);
            equipo4.AgregarJugador(jdr45);


            Equipo equipo5 = new Equipo("Racing", 650000000, 1918);

            Jugador jdr46 = new Jugador("Joaquin", "Altamirano", 21, 1.61, 85.9, "Argentina", "Derecho", "Racing", 5005000, "Mediocampista", 29908108);
            Jugador jdr47 = new Jugador("Roberto", "Ortiz", 22, 1.61, 85.9, "Argentina", "Izquierdo", "Racing", 540050000, "Mediocampista", 28900108);
            Jugador jdr48 = new Jugador("Oscar", "Boscovich", 18, 1.61, 85.9, "Argentina", "Derecho", "Racing", 84505000, "Delantero", 32279842);
            Jugador jdr49 = new Jugador("Felipe", "Lescano", 25, 1.61, 85.9, "Argentina", "Derecho", "Racing", 4505000, "Defensa", 26445642);
            Jugador jdr50 = new Jugador("Simon", "Cinicola", 32, 1.61, 85.9, "Argentina", "Izquierdo", "Racing", 32005000, "Mediocampista", 20840042);
            Jugador jdr51 = new Jugador("Willian", "Gomez", 39, 1.61, 85.9, "Paraguay", "Derecho", "Racing", 20005000, "Delantero", 32240242);
            Jugador jdr52 = new Jugador("Nahuel", "Acuña", 32, 1.61, 85.9, "Argentina", "Derecho", "Racing", 1505000, "Defensa", 30785642);
            Jugador jdr53 = new Jugador("Lucas", "Ibarra", 27, 1.61, 85.9, "Argentina", "Derecho", "Racing", 1005000, "Mediocampista", 32655042);
            Jugador jdr54 = new Jugador("Luis", "Landaberry", 29, 1.61, 85.9, "Chile", "Izquierdo", "Racing", 305000, "Mediocampista", 32021342);
            Jugador jdr55 = new Jugador("Carlos", "Agostino", 30, 1.61, 85.9, "Chile", "Derecho", "Racing", 6005000, "Defensa", 24245642);
            Jugador jdr56 = new Jugador("Luciano", "Severino", 20, 1.61, 85.9, "Chile", "Derecho", "Racing", 705000, "Delantero", 29245640);
            Jugador jdr57 = new Jugador("Lucio", "Corral", 27, 1.61, 85.9, "Argentina", "Izquierdo", "Racing", 4005000, "Delantero", 28240642);
            Jugador jdr58 = new Jugador("Sebastian", "Escobar", 38, 1.61, 85.9, "Argentina", "Derecho", "Racing", 34005000, "Defensa", 20245042);
            Jugador jdr59 = new Jugador("Valentino", "Kovak", 40, 1.61, 85.9, "Paraguay", "Derecho", "Racing", 405000, "Arquero", 30465242);
            Jugador jdr60 = new Jugador("Gonzalo", "Silveira", 17, 1.61, 85.9, "Argentina", "Derecho", "Racing", 1005000, "Defensa", 24230042);

            equipo5.AgregarJugador(jdr46);
            equipo5.AgregarJugador(jdr47);
            equipo5.AgregarJugador(jdr48);
            equipo5.AgregarJugador(jdr49);
            equipo5.AgregarJugador(jdr50);
            equipo5.AgregarJugador(jdr51);
            equipo5.AgregarJugador(jdr52);
            equipo5.AgregarJugador(jdr53);
            equipo5.AgregarJugador(jdr54);
            equipo5.AgregarJugador(jdr55);
            equipo5.AgregarJugador(jdr56);
            equipo5.AgregarJugador(jdr57);
            equipo5.AgregarJugador(jdr58);
            equipo5.AgregarJugador(jdr59);
            equipo5.AgregarJugador(jdr60);

            Liga.AgregarEquipo(equipo);
            Liga.AgregarEquipo(equipo2);
            Liga.AgregarEquipo(equipo3);
            Liga.AgregarEquipo(equipo4);
            Liga.AgregarEquipo(equipo5);

            Archivos<Equipo>.SerializeXML(Liga.ObtenerLista());
            Archivos<Equipo>.SerializeJson(Liga.equipos);
            Archivos<Jugador>.SerializeJson(Equipo.ObtenerTodosLosJugadores());
            return true;

        }

        /// <summary>
        /// Guarda los cambios en los archivos
        /// </summary>
        public static void GuardarCambios()
        {
            if (equipos.Count > 0)
            {
                Archivos<Equipo>.SerializeXML(Liga.ObtenerLista());
                Archivos<Equipo>.SerializeJson(Liga.ObtenerLista());
            }
        }

     
        /// <summary>
        /// Trae todos los equipos desde la DB
        /// </summary>
        private static void HarcodeoDB()
        {
            equipos = DBConnection.ConsultaEquipos("SELECT * FROM EQUIPOS");
            CargarDatos();
        }

        /// <summary>
        /// Invoca al delegado
        /// </summary>
        private static void CargarDatos()
        {
            Delegados.CargaDeDatosJugadores delegado = DatosJugadores;
            delegado.Invoke();
        }

        /// <summary>
        /// Trae todos los jugadores de la DB y los inserta en sus equipos
        /// </summary>
        public static void DatosJugadores()
        {
            List<Jugador> jugadores = DBConnection.ConsultaJugadores("SELECT * FROM JUGADORES");
            if (jugadores != null)
                Equipo.AgregarJugadores(jugadores);

        }

        /// <summary>
        /// Carga los datos desde  DB o XMLo Json
        /// </summary>
        /// <returns>true si cargo, sino false</returns>
        public static bool HarcodeoDatos()
        {
            bool cargoDatos = false;
            try
            {
                HarcodeoDB();
                if (equipos.Count > 0)
                {
                    cargoDatos = true;
                    return true;
                }

                HarcodeoXML();
                if (equipos.Count > 0)
                {
                    cargoDatos = true;
                    return true;
                }

                HarcodeoJSON();
                if (equipos.Count > 0)
                {
                    cargoDatos = true;
                    return true;
                }

                Harcodeo();
                if (equipos.Count > 0)
                {
                    cargoDatos = true;
                    return true;
                }

                throw new Exception();
            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }
            finally
            {
                List<Jugador> jdr = Equipo.ObtenerTodosLosJugadores();
                if (jdr.Count > 0 && cargoDatos)
                {
                    new Task(() => Archivos<Equipo>.SerializeXML(equipos)).Start();
                    new Task(() => Archivos<Equipo>.SerializeJson(equipos)).Start();
                }
            }
            return false;
        }
        /// <summary>
        /// Carga los datos desde XML
        /// </summary>
        private static void HarcodeoXML()
        {
            equipos = Archivos<Equipo>.DeserializeXML();
        }
        /// <summary>
        /// Carga los datos desde Json
        /// </summary>
        private static void HarcodeoJSON()
        {
            equipos = Archivos<Equipo>.DeserializeJson();
            if (equipos.Count > 0)
                Equipo.AgregarJugadores(Archivos<Jugador>.DeserializeJson());

        }
    }
}
