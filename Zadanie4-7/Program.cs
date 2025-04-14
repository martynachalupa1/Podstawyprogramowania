using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisz program obliczający wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury liczby naturalnej n.Użyj pętli while.Np.: dla n = 5 wypisz wynik 5 != 120.
            int n, i,wynik=1;
            Console.WriteLine("Podaj liczbę naturalna n:");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= n)
            {
                wynik *= i;
                i++;
            }
            Console.WriteLine("n silnia={0}", wynik);
            Console.ReadKey(true);


        }
    }
}
