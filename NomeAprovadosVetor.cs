using System;

namespace NomeAprovadosVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] dados;
            string[] vetNomes = new string[n];
            double[] vetNotas1 = new double[n];
            double[] vetNotas2 = new double[n];
            int i,j=0; 
            double media;
            string[] aprovados = new string[n];
            for (i = 0; i < n; i++)
            {
                dados = Console.ReadLine().Split(' ');
                vetNomes[i] = dados[0];
                vetNotas1[i] = double.Parse(dados[1]);
                vetNotas2[i] = double.Parse(dados[2]);

                media = (vetNotas1[i] + vetNotas2[i])/2;
                if (media >= 6){

                    aprovados[j] = vetNomes[i];
                    j++;
                }
            }
            int x = j;
            Console.WriteLine("Alunos Aprovados: ");
            for (i = 0; i < x; i++)
            {
                Console.WriteLine(aprovados[i]);
            }
        }
    }
}
