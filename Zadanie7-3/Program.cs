using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_3
{
    internal class Program
    {//Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r - promień koła i zwraca obliczoną wartość pola koła.Napisz program wykorzystujący funkcję pole_kola.
        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        {
            double r;
            Console.Write("Podaj liczbę r: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pole koła o promieniu {0} wynosi {1}", r, pole_kola(r));
            Console.ReadKey(true);
        }
    }
}
