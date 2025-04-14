using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_8__while
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while. 
            int n,i=2,suma=0;
            Console.WriteLine("Podaj liczbę n:");
            n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                if (n % i == 0)
                    suma += 1;
                i++;
            }
            if (suma == 0)
                Console.WriteLine("Liczba {0} jest pierwsza", n);
            else
                Console.WriteLine("Liczba {0} nie jest pierwsza", n);
            Console.ReadKey(true);
        }
    }
}
