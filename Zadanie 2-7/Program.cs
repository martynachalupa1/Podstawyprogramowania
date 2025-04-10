using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej odpowiednik rzymski. 
            int liczba;
            Console.WriteLine("Podaj liczbe arabską od 1 do 3999:");
            liczba = Convert.ToInt32(Console.ReadLine());
            //tysiące
            if (liczba >= 3000) { liczba -= 3000; Console.Write("MMM"); }
            else if (liczba>=2000) { liczba -= 2000; Console.Write("MM"); }
            else if (liczba>=1000) { liczba -= 1000; Console.Write("M"); }
            //setki
            if (liczba>=900) { liczba -= 900; Console.Write("CM"); }
            else if (liczba >= 800) { liczba -= 800; Console.Write("DCCC"); }
            else if (liczba >= 700) { liczba -= 700; Console.Write("DCC"); }
            else if (liczba >= 600) { liczba -= 600; Console.Write("DC"); }
            else if (liczba >= 500) { liczba -= 500; Console.Write("D"); }
            else if (liczba >= 400) { liczba -= 400; Console.Write("CD"); }
            else if (liczba >= 300) { liczba -= 300; Console.Write("CCC"); }
            else if (liczba >= 200) { liczba -= 200; Console.Write("CC"); }
            else if (liczba >= 100) { liczba -= 100; Console.Write("C"); }
            //dziesiątki
            if (liczba >= 90) { liczba -= 90; Console.Write("XC"); }
            else if (liczba >= 80) { liczba -= 80; Console.Write("LXXX"); }
            else if (liczba >= 70) { liczba -= 70; Console.Write("LXX"); }
            else if (liczba >= 60) { liczba -= 60; Console.Write("LX"); }
            else if (liczba >= 50) { liczba -= 50; Console.Write("L"); }
            else if (liczba >= 40) { liczba -= 40; Console.Write("XL"); }
            else if (liczba >= 30) { liczba -= 30; Console.Write("XXX"); }
            else if (liczba >= 20) { liczba -= 20; Console.Write("XX"); }
            else if (liczba >= 10) { liczba -= 10; Console.Write("X"); }
            //jedności
            switch (liczba)
            {
                case 1:Console.Write("I");break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
                default: Console.Write(""); break;
            }
            Console.ReadKey(true);
            


        }
    }
}
