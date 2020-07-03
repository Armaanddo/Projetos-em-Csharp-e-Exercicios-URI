using System;

namespace MaiorAlturaMenorAlturaMediaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] dados;
            double[] vetAlturas = new double[n];
            char[] vetSexo = new char[n];
            int i, contM = 0, contF = 0;
            double soma = 0, media;
            for (i = 0; i < n; i++)
            {
                dados = Console.ReadLine().Split(' ');
                vetAlturas[i] = double.Parse(dados[0]);
                vetSexo[i] = char.Parse(dados[1]);
                if (vetSexo[i] == 'M' || vetSexo[i] == 'm')
                {
                    contM++;

                }
                else
                    if (vetSexo[i] == 'F' || vetSexo[i] == 'f')
                {
                    contF++;
                    soma += vetAlturas[i];
                }
            }
            media = soma / contF;
            double maior = vetAlturas[0];
            for (i = 0; i < n; i++)
            {
                if (vetAlturas[i] > maior)
                {
                    maior = vetAlturas[i];
                }
            }
            double menor = vetAlturas[0];
            for (i = 0; i < n; i++)
            {
                if (vetAlturas[i] < menor)
                {
                    menor = vetAlturas[i];
                }
            }
            Console.WriteLine("Menor Altura = " + menor.ToString("F2"));
            Console.WriteLine("Maior Altura = " + maior.ToString("F2"));
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2"));
            Console.WriteLine("Numero de homens = " + contM);
        }
    }
}
