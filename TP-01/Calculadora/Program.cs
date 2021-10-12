using System;

namespace LaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando num1 = new Operando(5);
            if(num1.EsBinario("11000002001"))
                Console.WriteLine("Binario");
            else
                Console.WriteLine("No binario");
            
        }
    }
}
