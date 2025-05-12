using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7_5
{
    internal class Program
    {
        static int Czy_pierwsza (int liczba)
        {
            int i;
            for (i = 2;i<liczba; i++)
                if (liczba % i == 0) return 0;//liczba nie jest pierwsza
            return 1; //liczba musi być pierwsza
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Czy 12 jest liczbą pierwszą: {0}", Czy_pierwsza(12));
            Console.WriteLine("Czy 13 jest liczbą pierwszą: {0}", Czy_pierwsza(13));
            Console.ReadKey(true);//pauza
        }
    }
}
