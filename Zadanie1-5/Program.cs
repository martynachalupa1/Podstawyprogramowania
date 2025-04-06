using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_5
{
    class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka.
            double r, h, l, V, Pc;
            Console.WriteLine("Podaj promień podstawy stożka r:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wysokość stożka h:");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            V = Math.PI * r * r * h*1/3;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("Objętość = {0}", V);
            Console.WriteLine("Pole całkowite = {0}", Pc);
            Console.ReadKey(true);

        }
    }
}
