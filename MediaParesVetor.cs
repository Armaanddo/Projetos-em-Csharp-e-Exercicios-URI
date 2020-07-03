using System;

namespace MediaParesVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] valores = Console.ReadLine().Split();
            int[] vet = new int [n];
            int i,soma=0, cont=0;
            double media;
            for (i = 0; i < n; i++)
            {
                vet[i] = int.Parse(valores[i]);
                if (vet[i] % 2 == 0)
                {
                    cont++;
                    soma += vet[i];
                }
            }
            media = soma / cont;
            Console.WriteLine("Media dos valores pares: " + media.ToString("F1"));


        }
    }
}
