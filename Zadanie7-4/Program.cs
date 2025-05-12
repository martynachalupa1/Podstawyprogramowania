﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_4
{
    internal class Program
    {
        static int ile_cyfr(int liczba)
        {
            int i = 0; //ilość cyfr
            while (liczba / 10 > 0) //dopóki liczba jest co najmniej dwucyfrowa
            {
                liczba /= 10;
                i++;
            }
            return i + 1;

        }
        //testujemy naszą funkcję 
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 0 ma {0} cyfrę", ile_cyfr(0));
            Console.WriteLine("Liczba 1234 ma {0} cyfry", ile_cyfr(1234));
            Console.ReadKey(true); //pauza
        }
    }
}
