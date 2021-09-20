namespace LaCalculadora
{
    public class Operando
    {
        private double numero;
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

        private void SetNumero(string numero)
        {
            this.numero = ValidarOperando(numero);
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

        public string BinarioDecimal(string binario)
        {
            string retorno = "";
            int divisor = 2;
            long digito = 0;
            if (this.EsBinario(binario))
            {
                if (long.TryParse(binario, out long binParseado))
                {
                
                }
            }
            return retorno;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return  n1.numero - n2.numero;
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
