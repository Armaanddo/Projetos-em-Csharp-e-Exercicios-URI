using System;

namespace MostrarDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            int i, j, cont = 0;
            for (i = 0; i < n; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                for (j = 0; j < n; j++)
                {
                    
                    matriz[i, j] = int.Parse(numeros[j]);

                }
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {

                    if (matriz[i, j] < 0)
                    {
                        cont++;
                    }

                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j]+" ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
        }
    }
}
