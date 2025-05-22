using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie ósemkowym. 
            int[] tab = new int[1000];
            int i = 0, j, liczba;
            Console.Write("Podaj liczbe naturalną:");
            liczba = Convert.ToInt32(Console.ReadLine());
            while ((liczba / 8 != 0) || ((liczba / 8 == 0) && (liczba % 8 != 0))) 
            {
                tab[i++] = liczba % 8;
                liczba /= 8;
            }
            Console.Write("Liczba w systemie ósemkowym: ");
            for (j = i - 1; j >= 0; j--) Console.Write(tab[j]);
            Console.ReadKey(true);

        }
    }
}
