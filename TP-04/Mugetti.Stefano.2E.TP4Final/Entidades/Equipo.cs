using System;
using System.Collections.Generic;
using System.IO;

namespace Entidades
{
    [Serializable]
    public class Equipo : IGuardarCSV<Equipo>
    {
        string nombre;
        double valor;
        int añoCreacion;
        List<Jugador> jugadores;
        public event Delegados.AumentarValorEquipo EventoAumValor;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Valor { get => valor; set => valor = value; }
        public int AñoCreacion { get => añoCreacion; set => añoCreacion = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }


        public Equipo()
        {
            jugadores = new List<Jugador>();

        }
        public Equipo(string nombre, double valor, int añoCreacion) : this()
        {
            this.Nombre = nombre;
            this.Valor = valor;
            this.AñoCreacion = añoCreacion;
            jugadores = new List<Jugador>();
        }

        public string MostrarEquipo()
        {
            return $"\nNombre de equipo:{Nombre}\tAño de fundacion:{AñoCreacion}\nValor:${Valor}\n";
        }

        /// <summary>
        /// Agrega un jugador a la lista del equipo
        /// </summary>
        /// <param name="jugador">jugador a agregar</param>
        /// <returns>true si lo agrego, de lo contrario false</returns>
        public bool AgregarJugador(Jugador jugador)
        {
            if (!jugadores.Contains(jugador))
            {
                jugadores.Add(jugador);
                return true;
            }
            return false;
        }

        public List<Jugador> ObtenerListaJugadores()
        {
            return jugadores;
        }
        /// <summary>
        /// Elimina un jugador del equipo
        /// </summary>
        /// <param name="jdr">jugador a eliminar</param>
        /// <returns>false si no lo elimino, de lo contrario true</returns>
        public bool EliminarJugador(Jugador jdr)
        {
            if (jugadores.Remove(jdr))
                return true;

            return false;
        }
        /// <summary>
        /// Busca un jugador segun dni
        /// </summary>
        /// <param name="dniString">dni a buscar</param>
        /// <returns>null si no existe, de lo contrario el jugador</returns>
        public static Jugador BuscarJdrPorDni(string dniString)
        {
            if (!String.IsNullOrEmpty(dniString) && long.TryParse(dniString, out long dni))
            {
                List<Equipo> equipos = Liga.ObtenerLista();
                if (equipos != null)
                {
                    foreach (Equipo item in equipos)
                    {
                        List<Jugador> listaJugadores = item.ObtenerListaJugadores();
                        if (listaJugadores != null)
                        {
                            foreach (Jugador jdr in listaJugadores)
                            {
                                if (jdr.Dni == dni)
                                {
                                    return jdr;
                                }
                            }
                        }
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Obtiene la cantidad de jugadores del equipo pasado como instancia
        /// </summary>
        /// <returns>Cantidad de jugadores(int)</returns>
        public int ObtenerCantJrs()
        {
            return jugadores.Count;
        }
        /// <summary>
        /// Devuelve lista de todos los jugadores existentes
        /// </summary>
        /// <returns> lista con los jugadores</returns>
        public static List<Jugador> ObtenerTodosLosJugadores()
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            List<Jugador> listaTodosJugadores = new List<Jugador>();
            if (equipos != null)
            {
                foreach (Equipo item in equipos)
                {
                    List<Jugador> listaJugadores = item.ObtenerListaJugadores();
                    foreach (Jugador jdr in listaJugadores)
                    {
                        listaTodosJugadores.Add(jdr);
                    }
                }
            }
            return listaTodosJugadores;
        }

        /// <summary>
        /// Agrega los jugadores de una lista a su equipo correspondiente
        /// </summary>
        /// <param name="jugadores">lista a analizar</param>
        public static void AgregarJugadores(List<Jugador> jugadores)
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            if (equipos != null && jugadores != null)
            {
                foreach (Equipo item in equipos)
                {
                    foreach (Jugador jdr in jugadores)
                    {
                        if (item.Nombre.ToLower() == jdr.Club.ToLower())
                        {
                            item.AgregarJugador(jdr);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Elimina jugadores de la base de datos
        /// </summary>
        public void EliminarJugadores()
        {
            List<Jugador> jugadores = this.ObtenerListaJugadores();
            if (jugadores != null)
            {
                foreach (Jugador item in jugadores)
                {
                    DBConnection.EliminarJugador(item.Dni);
                }
            }
        }

        /// <summary>
        /// Invocacion del evento aumentar valor
        /// </summary>
        /// <param name="valor">Valor a aumentar</param>
        public void AumentarValorEvent(double valor)
        {
            if (EventoAumValor != null)
            {
                EventoAumValor.Invoke(valor);
            }
        }
        /// <summary>
        /// Manejador del evento aumentar valor
        /// </summary>
        /// <param name="valor">valor a aumentar</param>
        public void ManejadorAumentarValorEvent(double valor)
        {
            this.Valor += valor;
        }

        /// <summary>
        /// Guarda la lista de equipos filtrados y los guarda en una carpeta en el escritorio llamada Datos_Filtrados en formato en formato Equipos_Filtrar_Por(tipo filtrado).csv
        /// </summary>
        /// <param name="equipos">Lista de equipos</param>
        /// <param name="tipoFiltrado">Filtrado elegido por el usuario, sera el nombre del texto.csv</param>
        /// <returns>true si los guardo, de lo contrario false</returns>
        public bool GuardarListaCsv(List<Equipo> list, string tipoFiltrado)
        {
            if (list.Count > 0)
            {
                try
                {
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP4\Datos_Filtrados\";
                    string path = folder + "Equipos_Filtrar_Por_" + $"{tipoFiltrado}" + ".csv";

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    using (TextWriter texto = new StreamWriter(path, false))
                    {
                        texto.WriteLine("Nombre" + ";" + "Valor" + ";" + "Año creacion" + ";" + "Cantidad jugadores");
                        foreach (Equipo item in list)
                        {
                            texto.WriteLine(item.Nombre + ";" + item.Valor + ";" + item.AñoCreacion + ";" + item.ObtenerCantJrs());
                        }
                        return true;
                    };
                }
                catch (Exception e)
                {
                    Archivos<string>.InformarError(e.Message);
                }
            }
            return false;
        }
    }
}
