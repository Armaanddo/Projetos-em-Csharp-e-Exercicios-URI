using System;

namespace Idades1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            double media;
            int soma=0, cont = 0;
            while (idade > 0)
            {
                soma += idade;
                cont++;
                idade = int.Parse(Console.ReadLine());
            }
            media = (double)soma / cont;
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
