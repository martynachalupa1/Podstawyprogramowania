using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium_2
{
    internal class Program
    {
        static void odwrotnosc(int[]tablica)
        {
            for (int j = tablica.Length - 1; j >= 0; j--)
                Console.WriteLine(tablica[j]);
        }
       
        static void Main(string[] args)
        {
            int[] tablica = { 1, 6, 7, 8, 9, 10 };
            odwrotnosc(tablica);
            Console.ReadKey(true);
        }
    }
}
