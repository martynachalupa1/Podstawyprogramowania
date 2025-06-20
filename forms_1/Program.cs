using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, n, suma = 0;
            Console.Write("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) suma += i;

            string folder = @"c:\tmp";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // zapis do pliku
            string nazwa = @"c:\tmp\wynik1.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter zapis = new StreamWriter(plik);
            zapis.WriteLine(suma);
            zapis.Close();
            plik.Close();

            Console.ReadKey(true);
        }
    }
}
