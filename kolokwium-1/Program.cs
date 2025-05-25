using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium_1
{
    internal class Program
    {
        static int odejmowanie(int[,] tab1, int[,]tab2,int wiersz,int  kolumna)
        {
            return tab1[wiersz, kolumna] - tab2[wiersz, kolumna];
        }
        static void Main(string[] args)
        {
            int[,] tablica1 = { { 1, 17, 6 }, { 9, 20, 46 } };
            int[,] tablica2 = { { 87, 90, 4 }, { 1, 2, 3 } };
            Console.Write("Wynik odejmowania tych dwóch elementów tablicy wynosi {0}", odejmowanie(tablica1, tablica2, 0, 1));
            Console.ReadKey(true);
        }
    }
}
