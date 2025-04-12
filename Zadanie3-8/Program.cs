using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata przestępne od roku_początkowego do roku_końcowego włącznie. Użyj pętli for.
            int rok_poczatkowy, rok_koncowy, i;
            Console.WriteLine("Podaj rok początkowy:");
            rok_poczatkowy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj rok końcowy:");
            rok_koncowy = Convert.ToInt32(Console.ReadLine());
            for (i = rok_poczatkowy; i <= rok_koncowy; i++)
                if ((i % 4 == 0) && (i % 100 != 0) || (i % 400 == 0))
                    Console.Write("{0}, ", i);
            Console.ReadKey(true);


        }
    }
}
