using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_10
{
    class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący promień koła i wypisujący na ekranie jego pole i obwód. 
            double r,obwód,pole;
            Console.WriteLine("r = ");
            r = Convert.ToDouble(Console.ReadLine());
            obwód = 2 * Math.PI * r;
            pole = Math.PI * r * r;
            Console.WriteLine("Pole koła = {0}", pole);
            Console.WriteLine("Obwód koła = {0}", obwód);
            Console.ReadKey(true);
        }
    }
}
