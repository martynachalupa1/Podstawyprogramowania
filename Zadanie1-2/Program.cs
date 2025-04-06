using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_2
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący imię użytkownika i wypisujący na ekranie tekst "Witaj imię!".
            Console.WriteLine("Podaj swoje imie");
            string imie;
            imie = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Witaj {0}!", imie);
            Console.ReadKey(true);


        }
    }
}
