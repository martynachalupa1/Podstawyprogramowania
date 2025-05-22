using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_11
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie ósemkowym. 
            int[] tab = new int[1000];
            int i = 0, j, liczba;
            Console.Write("podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            string wynik = Convert.ToString(liczba, 8);
            Console.Write("Liczba {0} w systemie ósemkowym wynosi {1}", liczba, wynik);
            Console.ReadKey(true);
        }
    }
}
