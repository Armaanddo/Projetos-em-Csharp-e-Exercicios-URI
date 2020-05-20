using System;

namespace Media1URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double media = ((A * 3.5) + (B * 7.5)) / 11;
            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}
