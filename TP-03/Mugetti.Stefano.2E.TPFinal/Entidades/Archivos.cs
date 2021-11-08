using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public static class Archivos<T>
    {
        static int numeroInforme = 0;


        public static List<T> DeserializeJson()
        {
            List<T> lista = new List<T>();
            try
            {

                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP3\Datos_TP3\";
                string path = folder + $"Datos_" + $"{typeof(T).FullName}" + ".json";
                string json = File.ReadAllText(path);
                lista = JsonSerializer.Deserialize<List<T>>(json);
            }
            catch (Exception e)
            {
                string log = e.Message;
            }
            return lista;
        }
        /// <summary>
        /// Guarda una lista en un archivo formato .json
        /// </summary>
        /// <param name="lista">Lista a guardar</param>
        /// <returns>true si se pudo guardar, de lo contrario false</returns>
        public static bool SerializeJson(List<T> lista)
        {
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP3\Datos_TP3\";
                string path = folder + $"Datos_" + $"{typeof(T).FullName}" + ".json";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string listaSerializada = JsonSerializer.Serialize(lista);
                File.WriteAllText(path, listaSerializada);
                return true;
            }
            catch (Exception e)
            {
                string log = e.Message;
            }

            return false;
        }
        /// <summary>
        /// Guarda una lista en un archivo formato .xml
        /// </summary>
        /// <param name="lista">Lista a guardar</param>
        /// <returns>true si se pudo guardar, de lo contrario false</returns>
        public static bool SerializeXML(List<T> lista)
        {
            if (lista.Count > 0)
            {

                try
                {
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP3\Datos_TP3\";
                    string path = folder + $"Datos_" + $"{typeof(T).Name}" + ".xml";
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }

                    using (StreamWriter myStream = new StreamWriter(path))
                    {
                        XmlSerializer serializer = new XmlSerializer(lista.GetType());
                        serializer.Serialize(myStream, lista);

                        return true;
                    }

                }
                catch (Exception e)
                {
                    string log = e.Message;
                }
            }
            return false;
        }
        /// <summary>
        /// Deserializa un archivo formato .xml y lo devuelve en una lista
        /// </summary>
        /// <returns>Lista vacia si hubo error, de lo contrario la lista cargada</returns>
        public static List<T> DeserializeXML()
        {
            try
            {
                List<T> listaGenerica = new List<T>();
                string tipo = typeof(T).Name;

                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP3\Datos_TP3\";

                string path = folder + "Datos_" + $"{tipo}" + ".xml";

                if (!Directory.Exists(folder))
                    throw new Exception();

                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    FileStream file = File.Open(path, FileMode.Open);
                    listaGenerica = (List<T>)serializer.Deserialize(file);
                }
                return listaGenerica;
            }
            catch (Exception e)
            {
                string log = e.Message;
            }
            return null;
        }

        /// <summary>
        /// Guarda la lista de equipos filtrados y los guarda en una carpeta en el escritorio llamada Datos_Filtrados en formato Jugadores_Filtrar_Por(tipo filtrado).csv
        /// </summary>
        /// <param name="jugadores">Lista de jugadores</param>
        /// <param name="tipoFiltrado">Filtrado elegido por el usuario, sera el nombre del texto.csv</param>
        /// <returns>true si los guardo, de lo contrario false</returns>
        public static bool ListaJdrCsv(List<Jugador> jugadores, string tipoFiltrado)
        {
            if (jugadores.Count > 0)
            {
                try
                {
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP3\Datos_Filtrados\";
                    string path = folder + "Jugadores_Filtrar_Por_" + $"{tipoFiltrado}" + ".csv";

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    using (TextWriter texto = new StreamWriter(path, false))
                    {
                        texto.WriteLine("Nombre" + ";" + "Apellido" + ";" + "Edad" + ";" + "Altura" + ";" + "Peso" + ";" + "Nacionalidad" + ";" + "PieHabil" + ";" + "Club" + ";" + "Valor" + ";" + "Posicion" + ";" + "Dni");
                        foreach (Jugador item in jugadores)
                        {
                            texto.WriteLine(item.Nombre + ";" + item.Apellido + ";" + item.Edad + ";" + item.Altura + ";" + item.Peso + ";" + item.Nacionalidad + ";" + item.PieHabil + ";" + item.Club + ";" + item.Valor + ";" + item.Posicion + ";" + item.Dni);
                        }
                        return true;
                    };
                }
                catch (Exception e)
                {
                    string log = e.Message;
                }
            }
            return false;
        }
        /// <summary>
        /// Guarda la lista de equipos filtrados y los guarda en una carpeta en el escritorio llamada Datos_Filtrados en formato en formato Equipos_Filtrar_Por(tipo filtrado).csv
        /// </summary>
        /// <param name="equipos">Lista de equipos</param>
        /// <param name="tipoFiltrado">Filtrado elegido por el usuario, sera el nombre del texto.csv</param>
        /// <returns>true si los guardo, de lo contrario false</returns>
        public static bool ListaEquipoCsv(List<Equipo> equipos, string tipoFiltrado)
        {
            if (equipos.Count > 0)
            {
                try
                {
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP3\Datos_Filtrados\";
                    string path = folder + "Equipos_Filtrar_Por_" + $"{tipoFiltrado}" + ".csv";

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);


                    using (TextWriter texto = new StreamWriter(path, false))
                    {
                        texto.WriteLine("Nombre" + ";" + "Valor" + ";" + "Año creacion" + ";" + "Cantidad jugadores");
                        foreach (Equipo item in equipos)
                        {
                            texto.WriteLine(item.Nombre + ";" + item.Valor + ";" + item.AñoCreacion + ";" + item.ObtenerCantJrs());
                        }
                        return true;
                    };
                }
                catch (Exception e)
                {
                    string log = e.Message;
                }
            }
            return false;
        }
        /// <summary>
        /// Guarda los informes y los guarda en una carpeta en el escritorio llamada Informes en formato Informe_(numeroInforme).txt
        /// </summary>
        /// <param name="informe">informe a guardar en txt</param>
        /// <returns>true si lo guardo, de lo contrario false</returns>
        public static bool Informes(string informe)
        {
            if (informe != null)
            {
                try
                {
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP3\Informes\";
                    string path = folder + "Informe_" + $"{numeroInforme}" + ".txt";

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    using (TextWriter texto = new StreamWriter(path, false))
                    {
                        numeroInforme++;
                        texto.WriteLine(informe);
                        return true;
                    };
                }
                catch (Exception e)
                {
                    string log = e.Message;
                }
            }
            return false;
        }

        public static bool DatosHarcodeados()
        {
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP3\Harcodeo\";
                string path = folder + "Harcodeo" + ".txt";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                using (TextWriter texto = new StreamWriter(path, false))
                {
                    texto.WriteLine("Los datos han sido harcodeados");
                    return true;
                };
            }
            catch (Exception e)
            {
                string log = e.Message;
            }
            return false;
        }
    }
}
