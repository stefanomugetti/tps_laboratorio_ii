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
        static int numError = 0;

        public static List<T> DeserializeJson()
        {
            List<T> lista = new List<T>();
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP4\Datos_TP4\";
                string path = folder + $"Datos_" + $"{typeof(T).FullName}" + ".json";
                string json = File.ReadAllText(path);
                lista = JsonSerializer.Deserialize<List<T>>(json);
            }
            catch (Exception e)
            {
                InformarError(e.Message);
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
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP4\Datos_TP4\";
                string path = folder + $"Datos_" + $"{typeof(T).FullName}" + ".json";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string listaSerializada = JsonSerializer.Serialize(lista);
                File.WriteAllText(path, listaSerializada);
                return true;
            }
            catch (Exception e)
            {
                InformarError(e.Message);
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
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP4\Datos_TP4\";
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
                    InformarError(e.Message);
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

                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP4\Datos_TP4\";

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
                InformarError(e.Message);
            }
            return null;
        }

       
    
       
        /// <summary>
        /// Guarda los informes y los guarda en una carpeta en el escritorio llamada Informes en formato Informe_(numeroInforme).txt
        /// </summary>
        /// <param name="informe">informe a guardar en txt</param>
        /// <returns>true si lo guardo, de lo contrario false</returns>
        public static bool Informes(string informe,string tipoInforme)
        {
            if (informe != null)
            {
                try
                {
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP4\Informes\";
                    string path = folder + "Informe_" + $"{tipoInforme}" + ".txt";

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    using (TextWriter texto = new StreamWriter(path, false))
                    {
                        texto.WriteLine(informe);
                        return true;
                    };
                }
                catch (Exception e)
                {
                    InformarError(e.Message);
                }
            }
            return false;
        }
           
        public static bool InformarError(string error)
        {
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP4\Errores\";
                string path = folder + $"Error_{numError}" + ".txt";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                using (TextWriter texto = new StreamWriter(path, false))
                {
                    numError++;
                    texto.WriteLine(error);
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
