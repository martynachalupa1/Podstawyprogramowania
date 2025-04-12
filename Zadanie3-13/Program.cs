using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta prostokątnego jak na poniższym przykładzie.Użyj pętli for.
            int n, i, j;
            Console.WriteLine("Podaj liczbe naturalną n>4:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 2; j <i; j++) Console.Write(" ");
                for (j = 1; j <= i; j++) Console.Write("X");
                Console.WriteLine("");

            }
            Console.ReadKey(true);

        }
    }
}
