using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie informację ile liczb jest dodatnich, ujemnych i równych zero. 
            int n, i, ujemne=0,zero=0,dodatnie=0;
            Console.Write("Podaj elementy w tablicy n<=1000 ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tabn = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj element tab[{0}]", i);
                tabn[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (tabn[i] > 0) dodatnie += 1;
                else if (tabn[i]==0) zero += 1;
                else ujemne += 1;
            }
            Console.Write("W tablicy wystepuje {0} liczb dodatnich, {1} liczb równych zero, {2} liczb ujemnych.",dodatnie, zero, ujemne);
            Console.ReadKey(true);
        }
    }
}
