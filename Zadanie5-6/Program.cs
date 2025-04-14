using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n>0 i oblicz 1^1 + 2^2 + 3^3 + 4^4 + ⋯ + n^n. Nie można używać funkcji matematycznych.
            double n, i,suma=0;
            Console.WriteLine("Podaj liczbę naturalną n:");
            n = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                suma += Math.Pow(i, i);
                
            }
            Console.WriteLine("Suma wynosi {0}", suma);
            Console.ReadKey(true);

        }
    }
}
