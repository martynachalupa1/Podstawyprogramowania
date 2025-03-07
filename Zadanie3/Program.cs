using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian
            int liczba;
            Console.Write("Podaj liczbę całkowitą:");
            liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("liczba^3={0}", liczba * liczba * liczba);
            Console.ReadKey(true);
        }
    }
}
