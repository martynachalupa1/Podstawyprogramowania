﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie sumę wczytanych liczb.
            int[] tab = new int[1000];
            int i,n,suma;
            Console.WriteLine("Podaj liczbe elementów n<=1000 :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj tab[{0}]=: ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());

            }
            suma = 0;
            for (i = 0; i < n; i++)
            {
                suma += tab[i];
            }
            Console.WriteLine("Suma elementów tablicy wynosi {0}.", suma);
            Console.ReadKey(true);
        }
    }
}
