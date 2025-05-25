using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium_3
{
    internal class Program
    {
        static int [] scalenie(int[] tablica1, int[]tablica2)
        {
            int [] polaczona= new int[tablica1.Length + tablica2.Length];
            tablica1.CopyTo(polaczona, 0);
            tablica2.CopyTo(polaczona, tablica1.Length);
            return polaczona;
        
        }
        static void Main(string[] args)
        {
        }
    }
}
