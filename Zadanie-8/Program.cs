using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb naturalnych i wypisujący na ekranie wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj pętli foreach.

            int i, j, n,tmp;
            Console.Write("Podaj liczbę elementów w tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj element tab[{0}]: ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());            
            }
            for (i = 0; i < n-1; i++)
            {
                for (j = i+1; j < n; j++)
                    if (tab[i] > tab[j])
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; };
            }
            Console.Write("Posortowane i parzyste liczby z tablicy: ");
            foreach (int liczba in tab)
                {
                    if (liczba % 2 == 0)
                        Console.Write("{0}, ", liczba);
                }
            Console.ReadKey(true);
        }
    }
}
