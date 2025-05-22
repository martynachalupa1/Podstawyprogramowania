using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie najmniejszą i największą wczytaną liczbę.
            int[] tab = new int[1000];
            int n, i;
            Console.Write("Podaj liczbe elementów n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <n; i++)
            {
                Console.Write("Podaj element tab[{0}]: ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            for (i=0;i<n;i++)
            {
                if (tab[i] < min) 
                    min = tab[i];
                if (tab[i] > max) 
                    max = tab[i];
            }
            Console.Write("Najmniejszy element w tablicy to {0}, a największy to {1}", min, max);
            Console.ReadKey(true);
        }
    }
}
