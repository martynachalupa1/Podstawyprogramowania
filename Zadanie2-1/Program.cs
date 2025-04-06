using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_1
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to liczba parzysta, czy też nieparzysta.
            int liczba;
            Console.WriteLine("Podaj liczbę:");
            liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba % 2 == 0) Console.WriteLine("Liczba {0} jest parzysta", liczba);
            else Console.WriteLine("Liczba {0} nie jest parzysta", liczba);
            Console.ReadKey(true);
        }
    }
}
