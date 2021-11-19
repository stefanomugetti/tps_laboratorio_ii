using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Jugador:Persona,IGuardarCSV<Jugador>
    {
        string pieHabil;
        string club;
        double valor;
        string posicion;

        public Jugador() : base()
        {
        }
        public Jugador(string nombre, string apellido, int edad, double altura, double peso, string nacionalidad, string pieHabil, string club, double valor, string posicion,long dni) : base(nombre, apellido, edad, altura, peso, nacionalidad,dni)
        {
            this.PieHabil = pieHabil;
            this.Valor = valor;
            this.Posicion = posicion;
            this.Club = club;
        }

        public string PieHabil { get => pieHabil; set => pieHabil = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Club {
            get
            {
                return club;
            }
            set
            {
                if (value.ToLower() == "boca")
                    this.AumentarValorJugadorBoca();

                club = value;
            }
        }
        public string Posicion { get => posicion; set => posicion = value; }

        public override string Mostrar()
        {
            return $"{base.Mostrar()}\nPosicion:{Posicion}\tPie Habil:{pieHabil}\nValor:${Valor}\n{Club}\n";
        }
        public bool GuardarXML(List<Jugador> lista)
        {
            if (lista.Count > 0)
            {
                if (Archivos<Jugador>.SerializeXML(lista))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Jugador> CargarDeXML()
        {
            List<Jugador> lista = Archivos<Jugador>.DeserializeXML();
            if (lista.Count > 0)
            {
                return lista;
            }
            return null;
        }
        /// <summary>
        /// Guarda la lista de equipos filtrados y los guarda en una carpeta en el escritorio llamada Datos_Filtrados en formato Jugadores_Filtrar_Por(tipo filtrado).csv
        /// </summary>
        /// <param name="jugadores">Lista de jugadores</param>
        /// <param name="tipoFiltrado">Filtrado elegido por el usuario, sera el nombre del texto.csv</param>
        /// <returns>true si los guardo, de lo contrario false</returns>
        public bool GuardarListaCsv(List<Jugador> jugadores, string tipoFiltrado)
        {
            if (jugadores.Count > 0)
            {
                try
                {
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TP4\Datos_Filtrados\";
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
                    Archivos<string>.InformarError(e.Message);
                }
            }
            return false;
        }
    }
}
