using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {// Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać od użytkownika. Przykładowo dla n = 3 należy obliczyć sumę 1 + 3 + 5. Do obliczenia wartości sumy użyj pętli for.
            int i, n, suma=0;
            Console.WriteLine("Podaj liczbę naturalną:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    suma += i;
            }
            Console.Write("Suma wszystkich liczb naturalnych nieparzystych do {0} = {1}", n, suma);
            Console.ReadKey(true);

        }
    }
}
