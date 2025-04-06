using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_11
{
    class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący długości boków prostopadłościanu i wypisujący na ekranie jego objętość i pole całkowite.
            double a, b, c, V, Pc;
            Console.WriteLine("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c=");
            c = Convert.ToDouble(Console.ReadLine());
            V = a * b * c;
            Pc = 2 * a * c + 2 * a * b + 2 * b * c;
            Console.WriteLine("Objętość = {0}", V);
            Console.WriteLine("Pole całkowite = {0}", Pc);
            Console.ReadKey(true);
        }
    }
}
