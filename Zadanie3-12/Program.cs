using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {// Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for. Oto wydruk dla wysokości h = 6: 
            int dlugosc, i, j;
            Console.WriteLine("Podaj długość:");
            dlugosc = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= dlugosc; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", j * i);
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
