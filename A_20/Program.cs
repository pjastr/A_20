using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
