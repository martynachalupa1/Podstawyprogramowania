using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_3
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb. 
            int a, b, c;
            Console.WriteLine("Podaj liczbę a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c=");
            c = Convert.ToInt32(Console.ReadLine());
            if (a >= b && a >= c)
                Console.WriteLine("{0} jest największa z tych liczb", a);
            else if (b >= a && b >= c)
                Console.WriteLine("{0} jest największa z tych liczb", b);
            else
                Console.WriteLine("{0} jest najwieksza z tych liczb", c);
            if (a <= b && a <= c)
                Console.WriteLine("{0} jest najmniejsza z tych liczb", a);
            else if (b <= a && b <= c)
                Console.WriteLine("{0} jest najmniejsza z tych liczb", b);
            else
                Console.WriteLine("{0} jest najmniejsza z tych liczb", c);
            Console.ReadKey(true);

        }
    }
}
