using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    internal class Program
    {// Napisać funkcję o nazwie NWD zwracającą wartość największego wspólnego dzielnika dla jej dwóch argumentów będących liczbami naturalnymi.Napisz program testujący utworzoną funkcję.
        static double NWD(double a, double b)
        {
            while (b!=0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("NWD(48, 18) = " + NWD(48, 18)); // oczekiwane: 6
            Console.WriteLine("NWD(100, 25) = " + NWD(100, 25)); // oczekiwane: 25
            Console.WriteLine("NWD(81, 27) = " + NWD(81, 27)); // oczekiwane: 27
            Console.WriteLine("NWD(17, 5) = " + NWD(17, 5)); // oczekiwane: 1
            Console.WriteLine("NWD(0, 10) = " + NWD(0, 10)); // oczekiwane: 10
        }
    }
}
