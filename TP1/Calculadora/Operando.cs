using System;
namespace LaCalculadora
{
    public class Operando
    {
        private double numero;
        public double Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string numeroStr)
        {
            if (double.TryParse(numeroStr, out double numero))
                this.numero = numero;
        }

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
        public string DecimalBinario(string numDecimal)
        {
            string binario = "";
            int divisor=2;
            if (int.TryParse(numDecimal, out int flag))
            {
                while (flag > 0)
                {
                    binario = flag % divisor + binario;
                    flag = flag / divisor;
                }
            }
            return binario;
        }

        public string BinarioDecimal(string binario)
        {
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
            }
            return resultado.ToString();
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
            return n1.numero / n2.numero;
        }

        public double ValidarOperando(string numeroStr)
        {
            double retorno = 0;
            if (double.TryParse(numeroStr, out double numeroParseado))
                retorno = numeroParseado;

            return retorno;
        }

    }
}
