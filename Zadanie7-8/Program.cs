using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_8
{
    internal class Program
    {//Napisz funkcję, która posiada jeden parametr będący rokiem. Ma ona zwracać wartość 1, jeśli rok jest przestępny i 0 w pozostałych przypadkach.Napisz program testujący utworzoną funkcję.
        static int rok_przestepny(int rok)
        {
            if ((rok % 4 == 0) && ((rok % 100 != 0) || (rok % 400 == 0)))
                return 1;
            else
                return 0;
        }

        static void Main(string[] args)
        {
            int rok;
            Console.Write("Podaj rok: ");
            rok = int.Parse(Console.ReadLine());
            Console.Write("Czy rok {0} jest rokiem przestępnym: {1}", rok, rok_przestepny(rok));
            Console.ReadKey(true);
        }
    }
}
