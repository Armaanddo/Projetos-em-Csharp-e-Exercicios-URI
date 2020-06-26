using System;

namespace SomaParesURI1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int i = 0, somapar = 0, par = 2, j = 0, somaimpar=0 ;
            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    for(i=x; j<=4; i=i+2)
                    {
                        somapar += i;
                        j++;
                    }
                    Console.WriteLine(somapar);
                }
                else
                {
                    x = x + 1;
                    for (i = x; j <= 4; i = i + 2)
                    {
                        somaimpar += i;
                        j++;
                     }
                    Console.WriteLine(somaimpar);
                }
                j = 0;
                somaimpar = 0;
                somapar = 0;
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
