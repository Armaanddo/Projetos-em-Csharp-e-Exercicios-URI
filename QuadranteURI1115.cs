using System;

namespace QuadranteURI1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] qd = Console.ReadLine().Split(' ');
            int x = int.Parse(qd[0]);
            int y = int.Parse(qd[1]);

            while(x!=0 && y != 0)
            {
                if(x>0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }else
                    if(x>0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }else
                    if(x<0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }else
                    if(x<0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }

                qd = Console.ReadLine().Split(' ');
                x = int.Parse(qd[0]);
                y = int.Parse(qd[1]);
            }
        }
    }
}
