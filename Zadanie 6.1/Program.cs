using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];//tablica 1000 liczb typu int 
            int i, n; //i-licznik pętli, n-ilość elementów tablicy//wczytuje n 
            Console.Write("Podaj liczbę elementów w tablicy n<=1000:");
            n = Convert.ToInt32(Console.ReadLine());//wczytuje n elementó z tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Wyświetlamy elementy tablicy na ekranie 
            Console.Write("Elementy tablicy: ");
            for (i=0;i<n;i++)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.ReadKey(true);



        }
    }
}
