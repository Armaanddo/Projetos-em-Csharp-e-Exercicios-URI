using System;

namespace MediaValoresEAbaixoDaMediaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            double soma = 0;
            int cont = 0;
            double media;
            string[] valores = Console.ReadLine().Split(' ');
            int i;
            for (i = 0; i < n; i++)
            {
                vet[i] = double.Parse(valores[i]);
                soma += vet[i];
                cont++;
            }
            media = (double)soma / cont;
            Console.WriteLine("Media dos valores: " + media);
            Console.Write("Valores abaixo da media: ");
            for (i = 0; i < n; i++)
            {
                if (vet[i] < media)
                {
                    Console.Write(vet[i] + " ");
                }
            }

        }
    }
}
