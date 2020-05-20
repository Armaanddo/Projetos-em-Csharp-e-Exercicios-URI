using System;
using System.Globalization;
namespace MeuPrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do terreno: ");
            double comprimento;
            comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a altura do terreno: ");
            double altura;
            altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valorTerreno;
            Console.WriteLine("Digite o valor do metro quadrado: ");
            valorTerreno = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double areaTotal;
            areaTotal = comprimento * altura;
            double valorTotal;
            valorTotal = areaTotal * valorTerreno;
            Console.WriteLine("AREA = " + areaTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
