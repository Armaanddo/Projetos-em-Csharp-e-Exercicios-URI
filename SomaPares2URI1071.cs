using System;

namespace SomaParesC2URI1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int i, soma=0;
            if (x > y)
            {
                for (i = y+1; i < x; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                        
                    }
                }
            }
            else
            {
                for (i = x+1; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}
