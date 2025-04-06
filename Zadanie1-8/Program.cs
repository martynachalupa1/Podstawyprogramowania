using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_8
{
    class Program
    {
        static void Main(string[] args)
        {//Dany jest ciąg arytmetyczny a(n)=3n-1. Napisać program wczytujący numer wyrazu ciągu (n) i wypisujący na ekranie jego wartość.
            int n;
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3*{0}-1={1}", n, 3 * n - 1);
            Console.ReadKey(true);
        }
    }
}
