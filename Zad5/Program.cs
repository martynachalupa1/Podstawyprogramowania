﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący od użytkownika liczbę rzeczywistą x. Wczytuj tak długo wartość zmiennej x, aż przyjmie ona wartość dodatnią. Wczytaną dodatnią wartość liczby x wypisz na ekranie.Użyj pętli do -while.
            double x;
            do
            {
                Console.Write("Podaj x = ");
                x = Convert.ToDouble(Console.ReadLine());


            }while (x <= 0);
            Console.WriteLine("Wczytano liczbę x = {0}", x);
            Console.ReadKey(true);

        }
    }
}
