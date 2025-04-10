using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_3
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian wczytanej liczby.
            int liczba,sześcian;
            Console.WriteLine("Podaj liczbę całkowitą");
            liczba = Convert.ToInt32(Console.ReadLine());
            sześcian = liczba * liczba * liczba;
            Console.WriteLine("liczba^3 = {0}", sześcian);
            Console.ReadKey(true);

        }
    }
}
