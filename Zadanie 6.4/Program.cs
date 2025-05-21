using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie sumę wczytanych liczb.
            int[] tab = new int[1000];
            int i, n, suma=0;
            Console.Write("Podaj liczbe elelmentów w tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++) 
            {
                Console.Write("Podaj liczbę tab[{0}]: ",i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                suma += tab[i];
            }
            Console.Write("Suma wszystkich elelmentów w tablicy wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
