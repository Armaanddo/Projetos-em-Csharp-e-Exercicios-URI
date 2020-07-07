using System;
/*Exemplo:
 * Entrada
4
10 5 12 3
4 7 0 6
3 3 8 1
15 13 4 7

Saída
12
7
8
15
 */
namespace MaiorElementoDaLinhaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[m, m];
            int maiorLinha=0;
            int i, j, maior=0;
            for (i = 0; i < m; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                for (j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(numeros[j]);
                    
                }
            }
            maior = matriz[0, 0];
            int x = 0;
            Console.WriteLine("Os maior numero de cada linha: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (maior < matriz[i,j])
                    {
                        maior = matriz[i,j];
                        
                    } 
                }
                Console.WriteLine(maior);
                maior = 0;
            }
        }
    }
}
