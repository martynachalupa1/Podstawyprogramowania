using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_2
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero. 
            int liczba;
            Console.WriteLine("Podaj liczbę:");
            liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba > 0)
                Console.WriteLine("Liczba {0} jest dodatnia",liczba);
            if (liczba == 0)
                Console.WriteLine("Liczba {0} jest równa zero", liczba);
            else
                Console.WriteLine("Liczba {0} jest ujemna", liczba);
            Console.ReadKey(true);
        }
    }
}
