using System;

namespace MediaDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int cont = 0;
            double media, soma=0;
            if (idade < 0)
            {
                Console.WriteLine("impossivel calcular");
            }
            else
            {
                while (idade > 0)
                {
                    soma += idade;
                    cont++;
                    idade = int.Parse(Console.ReadLine());
                }
                media = soma / cont;
                Console.WriteLine(media.ToString("F2"));
            }
        }
    }
}
