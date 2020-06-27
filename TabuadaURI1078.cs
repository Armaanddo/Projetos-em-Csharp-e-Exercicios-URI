using System;

namespace TabuadaURI1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + n + " = " + i * n);
            }
        }
    }
}
