using System;

namespace NumeroPrimoURI1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0, j=0, k=1;
            while (k <= n)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                    if (x == 2)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                {
                    for (i = 1; i<x; i ++)
                    {
                        if (x % i == 0)
                        {
                            j++;
                        }
                    }
                    if (j == 1)
                    {
                        Console.WriteLine(x + " eh primo");
                    }
                    else
                    {
                        Console.WriteLine(x + " nao eh primo");
                    }
                    j = 0;
                }
                k++;
            }
        }
    }
}
