using System;

namespace GastoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 12;
            int t = int.Parse(Console.ReadLine());
            double vm = double.Parse(Console.ReadLine());
            double distancia = (t * vm);
            double tt = distancia / c;
            Console.WriteLine(tt.ToString("F3"));

        }
    }
}
