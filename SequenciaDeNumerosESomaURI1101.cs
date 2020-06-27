using System;

namespace SequenciaDeNumerosESoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, soma = 0;
            string[] numeros = Console.ReadLine().Split(' ');
            int m = int.Parse(numeros[0]);
            int n = int.Parse(numeros[1]);
            if(m<=0 && n <= 0)
            {
                Environment.Exit(1);   
            }else
            {
                if (m > n)
                {
                    for (i = n; i <= m; i++)
                    {
                        soma += i;     
                    }
                    for (i = n; i <= m; i++)
                    {
                        Console.Write(i+" ");
                        
                    }
                    Console.WriteLine("Sum=" + soma);
                }
                else
                {
                    for (i = m; i <= n; i++)
                    {
                        soma += i;
                    }
                    for (i = m; i <= n; i++)
                    {
                        Console.Write(i+" ");
                        
                    }
                    Console.WriteLine("Sum=" + soma);
                }
                soma = 0;
                numeros = Console.ReadLine().Split(' ');
                m = int.Parse(numeros[0]);
                n = int.Parse(numeros[1]);
            }
        }
    }
}
