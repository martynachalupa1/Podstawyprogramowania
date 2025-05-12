using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7_6
{
    internal class Program
    {
        static void kwadrat(int a, char znak_1, char znak_2)
        {
            int i, j;
            for (i = 1; i <= a; i++) Console.Write(znak_1); //pierwsza linia kwadratu
            Console.WriteLine("");
            for (i = 2; i <= a - 1; i++)
            {
                Console.Write(znak_1);
                for (j = 2; j <= a - 1; j++) Console.Write(znak_2);
                Console.Write(znak_1);
                Console.WriteLine("");
            }
            for (i = 1; i <= a; i++) Console.Write(znak_1);
        }
        static void Main(string[] args)
        {
            kwadrat(6,'#','*');
            Console.ReadKey(true);

        }
    }
}
