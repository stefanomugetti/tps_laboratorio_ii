using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Jugador:Persona
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
            this.Club = club;
            this.Valor = valor;
            this.Posicion = posicion;
        }

        public string PieHabil { get => pieHabil; set => pieHabil = value; }
        public string Club { get => club; set => club = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Posicion { get => posicion; set => posicion = value; }

        public override string Mostrar()
        {
            return $"{base.Mostrar()}\nPosicion:{Posicion}\tPie Habil:{pieHabil}\nValor:${Valor}\n{Club}\n";
        }
    }
}
