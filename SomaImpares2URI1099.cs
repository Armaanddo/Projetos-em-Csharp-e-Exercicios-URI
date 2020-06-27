using System;

namespace SomaImpares2URI1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j;
            int i = 0, soma=0;
            while (i != n)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int x = int.Parse(numeros[0]);
                int y = int.Parse(numeros[1]);
                if (x > y)
                {
                    for (j = y+1; j < x; j++)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }
                    }
                    Console.WriteLine(soma);
                }
                else
                {
                    for (j = x+1; j < y; j++)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }
                    }
                    Console.WriteLine(soma);
                }
                soma = 0;
                i++;
            }
        }
    }
}
