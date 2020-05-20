using System;

namespace CalculoSimplesURI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            String dado1 = Console.ReadLine();
            String dado2 = Console.ReadLine();

            String[] valores1 = dado1.Split(' ');
            int cP1 = int.Parse(valores1[0]);
            int nP1 = int.Parse(valores1[1]);
            double vP1 = double.Parse(valores1[2]);

            String[] valores2 = dado2.Split(' ');
            int cP2 = int.Parse(valores2[0]);
            int nP2 = int.Parse(valores2[1]);
            double vP2 = double.Parse(valores2[2]);

            double vt = ((nP1 * vP1)+(nP2 * vP2));
            Console.WriteLine("VALOR A PAGAR: R$ " + vt.ToString("F2"));
        }
    }
}
