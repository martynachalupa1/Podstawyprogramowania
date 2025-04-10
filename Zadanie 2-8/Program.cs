using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy da się z tych odcinków zbudować trójkąt, czy też nie.
            int a, b, c;
            Console.WriteLine("Podaj długość odcinka a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj długość odcinka b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj długość odcinka c:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Z tych odcinków można zbudować trójkąt.");
            else Console.WriteLine("Nie da się zbudować trójkąta z tych odcinków.");
            Console.ReadKey(true);
        }
    }
}
