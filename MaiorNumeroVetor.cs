using System;

namespace MaiorNumeroVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de valores que terá o vetor: ");
            int n = int.Parse(Console.ReadLine());
            double maiorNumero=0, index=0;
            
            double[] vet = new double[n];
            int i;
            string[] valores = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
            {
                
                vet[i] = double.Parse(valores[i]);
                maiorNumero = vet[0];

            }
            for (i = 1; i < n; i++)
            {
                if (maiorNumero < vet[i]) {
                    maiorNumero = vet[i];
                    index = i;
                }
            }
            Console.WriteLine("Maior valor é: "+maiorNumero);
            Console.WriteLine("Posição no vetor: "+index);


        }
    }
}
