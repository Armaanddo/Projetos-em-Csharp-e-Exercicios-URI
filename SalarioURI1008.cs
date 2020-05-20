using System;

namespace SalarioURI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroF = int.Parse(Console.ReadLine());
            int numeroH = int.Parse(Console.ReadLine());
            double valorH = double.Parse(Console.ReadLine());
            double salarioF;
            salarioF = numeroH * valorH;
            Console.WriteLine("NUMBER = " + numeroF);
            Console.WriteLine("SALARY = U$ " + salarioF.ToString("F2"));

        }
    }
}
