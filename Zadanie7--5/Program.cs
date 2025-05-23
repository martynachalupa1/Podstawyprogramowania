using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7__5
{
    internal class Program
    {//Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie utworzonej funkcji.
        static int czy_pierwsza(int liczba)
        {
            int i ;
            for (i=2;i<liczba;i++)
            {
                if (liczba % i == 0) return 0;
            }
            return 1;
        }

        static void Main(string[] args)
        {
            int liczba;
            Console.Write("Podaj liczbę: ");
            liczba = int.Parse(Console.ReadLine());
            Console.Write("Czy liczba {0} jest liczbą pierwszą {1}", liczba, czy_pierwsza(liczba));
            Console.ReadKey(true);
        }
    }
}
