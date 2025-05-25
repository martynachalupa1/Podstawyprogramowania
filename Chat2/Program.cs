using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat2
{
    internal class Program
    {
        static double srednia(int[]tablica)
        {
            double suma = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                suma += tablica[i];
            }
            return suma / tablica.Length;
        }
        static void Main(string[] args)
        {
            int[] tablica = { 1, 3, 5 };
            Console.Write(srednia(tablica));
            Console.ReadKey(true);
        }
    }
}
