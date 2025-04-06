using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_9
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów wczytanych liczb. 
            double a, b;
            Console.WriteLine("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}^2+{1}^2={2}", a, b, a * a + b * b);
            Console.ReadKey(true);
        }
    }
}
