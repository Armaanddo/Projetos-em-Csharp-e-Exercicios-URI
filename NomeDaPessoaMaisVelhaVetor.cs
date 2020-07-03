using System;

namespace NomeDaPessoaMaisVelhaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            string[] vetNome = new string[n];
            int[] vetIdades = new int[n];
            for (i = 0;i < n; i++){
                string[] valores = Console.ReadLine().Split();
                vetNome[i] = valores[0];
                vetIdades[i] = int.Parse(valores[1]);
            }
            int maisVelha = vetIdades[0];
            int index=0;
            for (i = 1; i < n; i++)
            {
                if (vetIdades[i] > maisVelha)
                {
                    maisVelha = vetIdades[i];
                    index = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: "+vetNome[index]);

        }
    }
}
