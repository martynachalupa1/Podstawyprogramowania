using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_dodatkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wypisz 10 liczb i podaj ile jest dodatnich, ujemnych i równych zero.
            int n, i,dodatnie=0,ujemne=0,zero=0;
            i = 1;
            do
            {
                Console.WriteLine("Podaj liczbę n:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0) dodatnie += 1;
                else if (n == 0) zero += 1;
                else if (n < 0) ujemne += 1;
                i++;
            } while (i <= 10);
            Console.WriteLine("Jest {0} liczb dodatnich, {1} liczb ujemnych i {2} liczb równych zero.",dodatnie,ujemne,zero);
            Console.ReadKey(true);

            
        }
    }
}
