using System;

namespace SomaDeVetoresMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            string[] dadosMatriz = Console.ReadLine().Split(' ');
            string[] numeros;
            m = int.Parse(dadosMatriz[0]);
            n = int.Parse(dadosMatriz[1]);
            int[] vetSoma = new int[m];
            int[,] mat = new int[m, n];
            int i, j, soma = 0;

            for (i = 0; i < m; i++)
            {
                numeros = Console.ReadLine().Split(' ');
                for (j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(numeros[j]);

                }
            }
            for (i = 0; i < m; i++)
            { 
                for (j = 0; j < n; j++)
                {
                    soma += mat[i,j];
                    vetSoma[i] = soma;

                }
                soma = 0;
            }
            for (i = 0; i < m; i++)
            {
                Console.WriteLine(vetSoma[i]);
            }
            
        }
    }
}
