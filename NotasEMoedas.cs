using System;


namespace NotasEMoedasURI1021
{
    class Program
    {
        static void Main(string[] args)
        {
            String valor = Console.ReadLine();
            String [] Cedulas = valor.Split('.');
            int n = int.Parse(Cedulas[0]);
            int c = int.Parse(Cedulas[1]);


            int n100 = n / 100;
            int n50 = (n % 100) / 50;
            int n20 = ((n % 100) % 50) / 20;
            int n10 = (((n % 100) % 50) % 20) / 10;
            int n5 = ((((n % 100) % 50) % 20) % 10) / 5;
            int n2 = (((((n % 100) % 50) % 20) % 10) % 5) / 2;
            int resto = ((((((n % 100) % 50) % 20) % 10) % 5) % 2) / 1;
            if (resto == 1)
            {
                c = c + 100;
            }
                
                int m100 = c / 100;
                int m50 = (c % 100) / 50;
                int m25 = ((c % 100) % 50) / 25;
                int m10 = (((c % 100) % 50) % 25) / 10;
                int m5 = ((((c % 100) % 50) % 25) % 10) / 5;
                int m1 = (((((c % 100) % 50) % 25) % 10) % 5) / 1;





            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m100 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m1 + " moeda(s) de R$ 0.01");



        }
    }
}
