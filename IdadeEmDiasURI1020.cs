using System;

namespace IdadeEmDiasURI1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int a = d / 365;
            int m = (d % 365) / 30;
            int dias = ((d % 365) % 30) ;

            Console.WriteLine(a + " ano(s)");
            Console.WriteLine(m + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
