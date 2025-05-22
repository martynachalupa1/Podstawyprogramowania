using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie szesnastkowym. Wskazówka: 10 - A, 11 - B, 12 - C, 13 - D, 14 - E, 15 - F
            char[] tab = new char[1000];
            int i = 0, j, liczba;
            Console.Write("Podaj liczbę naturalną: ");
            liczba = int.Parse(Console.ReadLine());
            while ((liczba / 16 != 0) || ((liczba / 16 == 0) && (liczba % 16 != 0)))
            {
                if (liczba % 16 < 10)
                    tab[i++] = (char)(liczba % 10);
                else
                    tab[i++] = (char)('A' + ((liczba % 16) - 10));
                liczba /= 16;

            }
            Console.Write("Twoja liczba w systemie szesnastkowym wynosi ");
            for (j = i - 1; j >= 0; j--) Console.Write(tab[j]);
            Console.ReadKey(true);
        }
    }
}
