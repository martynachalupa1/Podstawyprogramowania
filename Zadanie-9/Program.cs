using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie sumę kwadratów wczytanych liczb. 
            int n, i, suma = 0;
            Console.Write("Podaj elementy w tablicy n<=1000 ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tabn = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj element tab[{0}]", i);
                tabn[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
                suma += tabn[i] * tabn[i];
            Console.Write("Suma kwadratów wszystkich liczb wczytanych do tablicy wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
