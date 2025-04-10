using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {//Dana jest funkcja kwadratowa f(x)=ax^2+bx+c. Napisać program wczytujący współczynniki funkcji kwadratowej(a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich braku.
            double a, b, c, delta,x1,x2;
            Console.WriteLine("Podaj współczynnik x^2 a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik x b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c:");
            c = Convert.ToDouble(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Miejsca zerowe tej funkcji to {0} i {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Miejsce zerowe tej funkcji to {0}", x1);
            }
            else Console.WriteLine("Funkcja ma brak miejsc zerowych.");
            Console.ReadKey(true);
        }
    }
}
