﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wypisz tabliczkę mnożenia do 100 w formie tabelki:
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                    Console.Write("{0} ", j * i);
                Console.WriteLine("");
            }
            Console.ReadKey(true);
            


        }
    }
}
