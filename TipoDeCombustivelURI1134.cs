using System;

namespace TipoDeCombustivelURI1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, g = 0, d = 0;
            while (n!=4)
            {
                if (n == 1)
                {
                    a++;
                }else
                    if (n == 2)
                {
                    g++;
                }else
                    if (n == 3)
                {
                    d++;
                }
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + a);
            Console.WriteLine("Gasolina: " + g);
            Console.WriteLine("Diesel: " + d);
        }
    }
}
