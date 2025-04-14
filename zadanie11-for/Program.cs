using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie11_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, suma = 0, liczba = 0;
            Console.Write("Podaj liczbe n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                liczba = 2 * i - 1;
                suma += liczba;
            }
            Console.WriteLine("Suma {0} liczb nieparzystych to {1}", n, suma);
            Console.ReadKey(true);
        }
    }
}
