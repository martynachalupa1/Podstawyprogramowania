using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n(n> 1). Narysuj na ekranie z gwiazdek trójkąt prostokątny.Użyj pętli for. Przykładowo dla n = 3 narysowany trójkąt powinien wyglądać:
            int n, i, j;
            Console.WriteLine("Podaj liczbe naturalną n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);

        }
    }
}
