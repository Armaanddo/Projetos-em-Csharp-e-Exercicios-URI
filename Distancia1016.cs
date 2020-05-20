using System;

namespace Distancia1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 60;
            int y = 90;
            int d = int.Parse(Console.ReadLine());
            int tt = (60 / (y - x)) * d;

            Console.WriteLine(tt + " minutos");
        }
    }
}
