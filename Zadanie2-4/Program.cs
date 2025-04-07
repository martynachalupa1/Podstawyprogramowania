using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej największej z tych liczb.
            double a, b, c, d, e, max, min;
            Console.WriteLine("Podaj liczbe a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe d=");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe e=");
            e = Convert.ToDouble(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Najmniejsza z tych liczb to {0}", min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Największa z tych liczb to {0}", max);
            Console.ReadKey(true);
        }
    }
}
