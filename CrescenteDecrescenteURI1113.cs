using System;

namespace CrescenteDecrescenteURI1113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);

            while (n1 != n2)
            {
                if (n1 < n2)
                {
                    Console.WriteLine("Crescente");
                    
                }
                else
                    Console.WriteLine("Decrescente");

                numeros = Console.ReadLine().Split(' ');
                n1 = int.Parse(numeros[0]);
                n2 = int.Parse(numeros[1]);
            }
        }
    }
}
