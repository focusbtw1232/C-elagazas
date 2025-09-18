using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Console.Write("Kérlek adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
                Console.WriteLine("Páros");
            else
                Console.WriteLine("Páratlan");
            Console.ReadLine();
            //2. feladat
            Console.WriteLine("Kérlek adj meg egy számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            if (szam1 > 0)
                Console.WriteLine("Pozitív");
            else if (szam1 < 0)
                Console.WriteLine("Negatív");
            else
                Console.WriteLine("Nulla");

            //3.feladat
            Console.WriteLine("Add meg a hónap sorszámát: ");
            int honap = int.Parse(Console.ReadLine());
            if (honap >= 3 && honap <= 5)
                Console.WriteLine("Tavasz");
            else if (honap >= 6 && honap <= 8)
                Console.WriteLine("Nyár");
            else if (honap >= 9 && honap <= 11)
                Console.WriteLine("Ősz");
            else
                Console.WriteLine("Tél");
            //4.feladat
            Console.WriteLine("Add meg az életkorodat: ")
            int eletkor = int.Parse(Console.ReadLine());
            if (eletkor >= 18)
                Console.WriteLine("Már szavazhatsz");
            else
                Console.WriteLine("Még nem szavazhatsz");
            //5.feladat
            Console.WriteLine("Add meg a jegyed: ");
            int jegy = int.Parse(Console.ReadLine());
            if (jegy < 3)
                Console.WriteLine("A jegyed elégtelen");
            else if (jegy == 3)
                Console.WriteLine("A jegyed elégséges");
            else if (jegy == 4)
                Console.WriteLine("A jegyed jó");
            else
                Console.WriteLine("A jegyed jeles");


        }
    }
}
