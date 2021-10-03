namespace LaCalculadora
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el char pasado por parametro sea un operador valido
        /// </summary>
        /// <param name="operador">Char a analizar</param>
        /// <returns>Retorna + si el operador es invalido, o el operador elegido, si es valido</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            switch (operador)
            {
                case '-':
                    retorno = '-';
                    break;
                case '*':
                    retorno = '*';
                    break;
                case '/':
                    retorno = '/';
                    break;
            }
            return retorno;
        }
        /// <summary>
        /// Realiza la operacion entre dos operandos
        /// </summary>
        /// <param name="num1">Primer numero de la operacion</param>
        /// <param name="num2">Segundo numero de la operacion</param>
        /// <param name="operador">Operacion a realizar</param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = -1;
            char operadorValidado = ValidarOperador(operador);

            switch (operadorValidado)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':                   
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }
    }
}
