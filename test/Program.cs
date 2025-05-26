using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static int[] odwrotnosc(int[]tab)
        {
            int[] nowa = new int[tab.Length];
            for (int i=0;i<tab.Length;i++)
            {
                nowa[i] = tab[tab.Length - 1 - i];
            }
            return nowa;
        }
        static void Main(string[]args)
        {
            int[] tablica = { 1, 2, 3, 4, 5 };
            Console.Write("Odwrotnie: {0}", odwrotnosc(tablica));
            Console.ReadKey(true);
        }
    }
}
