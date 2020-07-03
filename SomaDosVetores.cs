using System;

namespace SomaDosVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Quantidade de valores:");
            int n1 = int.Parse(Console.ReadLine());
            string[] valores1 = Console.ReadLine().Split(' ');
            string[] valores2 = (Console.ReadLine().Split(' '));
            int[] vet1 = new int[n1];
            int[] vet2 = new int[n1];
            

            for (i = 0; i < n1; i++)
            {
                vet1[i] = int.Parse(valores1[i]);
            }
            for (i = 0; i < n1; i++)
            {
                vet2[i] = int.Parse(valores2[i]);
            }
            
                int[] vet3 = new int[n1];
                for (i = 0; i < n1; i++)
                {

                    vet3[i] = vet1[i] + vet2[i];
                }
                for (i = 0; i < n1; i++)
                {

                    Console.Write(vet3[i] + " ");
                }
         }

    }
}
