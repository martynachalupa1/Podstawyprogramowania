using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_1._2
{
    internal class Program
    {
        static int suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, suma(a, b));
            Console.ReadKey(true);
        }
    }
}
