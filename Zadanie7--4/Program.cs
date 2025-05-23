using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7__4
{
    internal class Program
    {//Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr.
        static int ile_cyfr(int liczba)
        {
            int cyfra = 0;//ilość cyfr
            while (liczba/10>0)//dopóki liczba jest co najmniej dwucyfrowa
            {
                liczba /= 10;
                cyfra++;
            }
            return cyfra + 1;
        }
        static void Main(string[] args)
        {
            int liczba;
            Console.WriteLine("Podaj liczbę: ");
            liczba = int.Parse(Console.ReadLine());
            Console.Write("Liczba {0} posiada {1} cyfr", liczba, ile_cyfr(liczba));
            Console.ReadKey(true);
        }
    }
}
