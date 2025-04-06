using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_4
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
            int a, b;
            Console.WriteLine("Podaj bok prostokąta:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugi bok prostokąta:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Obwód tego prostokąta wynosi {0} a pole tego prostokąta wynosi {1}", 2 * a + 2 * b, a * b);
            Console.ReadKey(true);

        }
    }
}
