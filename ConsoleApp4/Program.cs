using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {//Napisać funkcję, która posiada trzy argumenty będące współczynnikami a, b, c funkcji kwadratowej y = ax2 + bx + c.Funkcja ma zwracać ilość pierwiastków zadanej funkcji kwadratowej.Napisz program testujący utworzoną funkcję.
        static int funkcja_kwadratowa(int a, int b, int c)
        {
            if (b * b - 4 * a * c > 0) return 2;
            else if (b * b - 4 * a * c == 0) return 1;
            else
                return 0;

        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Podaj liczbę a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("y={0}x^2 + {1}x + {2} posiada {3} miejsca zerowe.", a, b, c, funkcja_kwadratowa(a, b, c));
            Console.ReadKey(true);
        }
    }
}
