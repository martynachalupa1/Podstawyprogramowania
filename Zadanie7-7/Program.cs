using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_7
{
    internal class Program
    {//Napisz funkcję posiadającą dwa argumenty: p, q – długości przekątnych deltoidu.Funkcja ma zwracać pole deltoidu dla zadanych argumentów.Napisz program testujący utworzoną funkcję.Wskazówka: P = p * q / 2.
        static int pole_deltoidu(int p,int q)
        {
            return p * q / 2;
        }
        static void Main(string[] args)
        {
            int p, q;
            Console.Write("Podaj 1 przekątną deltoidu p: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Podaj 2 przekątną deltoidu q: ");
            q = int.Parse(Console.ReadLine());
            Console.Write("Pole deltoidu o przekątnych {0} i {1} wynosi {2}", p, q, pole_deltoidu(p, q));
            Console.ReadKey(true);
        }
    }
}
