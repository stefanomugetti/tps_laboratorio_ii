namespace LaCalculadora
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno;
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
                default:
                    retorno = '+';
                    break;
            }
            return retorno;
        }
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
                    if (num2.ToString() == "0")
                        resultado = double.MinValue;

                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }
    }
}
