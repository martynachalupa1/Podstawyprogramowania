using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program sumujący kolejne liczby całkowite podawane przez użytkownika, aż do napotkania zera. Wypisz otrzymaną sumę na ekranie.Użyj pętli do -while.
            int  i, suma=0;
            do
            {
                Console.WriteLine("Podaj liczbę całkowitą i:");
                i = Convert.ToInt32(Console.ReadLine());
                suma += i;
            } while (i!=0);
            Console.WriteLine("Suma tych liczb całkowitych wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
