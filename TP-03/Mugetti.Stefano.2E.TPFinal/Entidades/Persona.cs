using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int edad;
        double altura;
        double peso;
        string nacionalidad;
        long dni;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, int edad, double altura, double peso, string nacionalidad,long dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Altura = altura;
            this.Peso = peso;
            this.Dni = dni;
            this.Nacionalidad = nacionalidad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (Validaciones.DniValido(value) && !Liga.JugadorRepetido(value))
                {
                    this.dni = value;
                }
                else
                {
                    throw new DniException("Dni invalido");
                }
            }
        }

        public virtual string Mostrar()
        {
            return $"Nombre:{Nombre}\tApellido:{Apellido}\tEdad:{Edad}\nAltura:{Altura}\tPeso:{Peso}\nNacionalidad:{Nacionalidad}";
        }
    }
}
