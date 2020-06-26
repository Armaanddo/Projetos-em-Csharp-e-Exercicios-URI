using System;

namespace SenhaFixaURI1114
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "2002";
            string entrada = Console.ReadLine();
            while (entrada != senha)
            {
                Console.WriteLine("Senha Invalida");
                entrada = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
