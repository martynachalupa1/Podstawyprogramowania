﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Spośród liczb od 1 do 100 wypisz na ekranie wszystkie liczby podzielne przez 13. Użyj pętli for.
            int i;
            for (i = 1; i <= 100; i++)
                if (i % 13 == 0)
                    Console.Write("{0}, ", i);
            Console.ReadKey(true);

        }
    }
}
