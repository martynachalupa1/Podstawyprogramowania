﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który nie jest trójkątem prostokątnym. Użyj pętli for. Przykładowo dla n = 3 narysowany trójkąt powinien wyglądać:
            int n, i, j;
            Console.WriteLine("Podaj liczbe naturalną n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <=n-i; j++) Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++) Console.Write("*");
                Console.WriteLine("");

                    
            }
            Console.ReadKey(true);

        }
    }
}
