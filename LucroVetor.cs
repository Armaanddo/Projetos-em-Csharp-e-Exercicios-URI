using System;

namespace LucroVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] dados;
            string[] mercadorias = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];
            int i;
            double lucro, somaC =0, somaV = 0, somaL = 0;
            int lab10 = 0, lab20 = 0, lac20 = 0;
            for (i = 0; i < n; i++)
            {
                dados = Console.ReadLine().Split(' ');
                mercadorias[i] = dados[0];
                precoCompra[i] = double.Parse(dados[1]);
                precoVenda[i] = double.Parse(dados[2]);
                somaC += precoCompra[i];
                somaV += precoVenda[i];


            }
            for (i = 0; i < n; i++)
            {
                lucro = ((precoVenda[i] * 100) / precoCompra[i])-100;
                
                if (lucro < 10)
                {
                    lab10++;
                }
                else
                    if (lucro >= 10 && lucro <= 20)
                {
                    lab20++;
                }
                else
                    if(lucro>20)
                    lac20++;   
            }
            Console.WriteLine("Lucro abaixo de 10%: " + lab10);
            Console.WriteLine("Lucro entre 10% e 20%: " + lab20++);
            Console.WriteLine("Lucro acima de 20%: " + lac20++);
            Console.WriteLine("Valor total de compra: " + somaC.ToString("F2"));
            Console.WriteLine("Valor total de venda: " + somaV.ToString("F2"));
            Console.WriteLine("Lucro total: " + (somaV-somaC).ToString("F2"));


        }
    }
}
