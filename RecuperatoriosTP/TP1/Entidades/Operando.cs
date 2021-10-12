using System;
namespace LaCalculadora
{
    public class Operando
    {
        private double numero;
        public string Numero
        {
            set 
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        /// <summary>
        /// Construye un numero inicializado en 0
        /// </summary>
        public Operando():this(0)
        {

        }
        /// <summary>
        /// Construye un operando con el valor pasado por parametro 
        /// </summary>
        /// <param name="numero">Numero asignado al atributo numero</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Construye un operando a partir de un string
        /// </summary>
        /// <param name="numeroStr">Numero del tipo string</param>
        /// 
        public Operando(string numeroStr)
        {
            this.Numero = numeroStr;
        }
        /// <summary>
        /// Valida que el string pasado por parametro sea un numero binario
        /// </summary>
        /// <param name="binario">Cadena a verificar si es un numero binario</param>
        /// <returns>Retorna true(si es binario) o false (si no es binario)</returns>
        public bool EsBinario(string binario)
        {
            bool retorno = true;
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1' || binario[i] == '0')
                    retorno = true;
                else
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Realiza el pasaje de un numero decimal a un numero binario
        /// </summary>
        /// <param name="numDecimal">Cadena que intentara transformar en binario</param>
        /// <returns>Retorna "valor invalido" si no se puede transformar o el numero transformado a binario, si se pudo</returns>
        public string DecimalBinario(string numDecimal)
        {
            string binario = numDecimal;
            int divisor=2;
            int numeroAbsoluto = 0;
            if (int.TryParse(numDecimal, out int numeroParseado))
            {
                binario = "";
                numeroAbsoluto = Math.Abs(numeroParseado);
                while (numeroAbsoluto > 0)
                {
                    binario = numeroAbsoluto % divisor + binario;
                    numeroAbsoluto = numeroAbsoluto / divisor;
                }
            }
            return binario;
        }
        /// <summary>
        /// Realiza el pasaje de un numero binario a un numero decimal
        /// </summary>
        /// <param name="binario">Cadena que intentara transformar en decimal</param>
        /// <returns>Retorna "valor invalido" si no se puede transformar o el numero transformado a decimal, si se pudo</returns>
        public string BinarioDecimal(string binario)
        {
            string resultadoString = binario;
            int residuo = 0;
            int exponente = 0;
            int resultado = 0;
            
            if (this.EsBinario(binario) && int.TryParse(binario,out int numero))
            {                       
                while (numero != 0)
                {
                    residuo = numero % 10;
                    numero = numero / 10;
                    resultado += (int)(residuo * Math.Pow(2, exponente));
                    exponente++;
                }
                resultadoString = resultado.ToString();
            }
            return resultadoString;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }

            return n1.numero / n2.numero;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametro sea un numero valido
        /// </summary>
        /// <param name="numeroStr">Cadena a ser analizada</param>
        /// <returns>Retorna 0 si no es valido o el numero parseado, si es valido</returns>
        public double ValidarOperando(string numeroStr)
        {
            double retorno = 0;
            if (double.TryParse(numeroStr, out double numeroParseado))
                retorno = numeroParseado;

            return retorno;
        }

    }
}
