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
            Console.WriteLine("Add meg az életkorodat: ");
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
            //6.feladat 
            Console.WriteLine("Találd ki melyik számra gondoltam: ");
            int kitalal = int.Parse(Console.ReadLine());
            int kitalalt = 20;
            if (kitalal > kitalalt)
                Console.WriteLine("A szám amire gondoltam kisebb");
            else if (kitalal < kitalalt)
                Console.WriteLine("A szám amire gondoltam nagyobb");
            else
                Console.WriteLine("Gratulálok eltaláltad");
            //7.feladat
            Console.WriteLine("Adj meg egy számot: ");
            int jo = int.Parse(Console.ReadLine());
            if (jo > 0 && jo % 2 == 0)
                Console.WriteLine("A szám pozitív és páros");
            else
                Console.WriteLine("A szám nem pozitív és nem páros");
            //8.feladat
            Console.WriteLine("Adj meg egy karaktert: ");
            char karakter = Console.ReadKey().KeyChar;
            if (char.IsDigit(karakter))
                Console.WriteLine("Ez egy szám");
            else if (char.IsLetter(karakter))
                Console.WriteLine("Ez egy betű");
            else
                Console.WriteLine("Ez se nem szám se nem betű");
            //9.feladat
            string jelszo = "titok123";
            Console.WriteLine("Add meg a jelszót: ");
            string jelszokitalalas = Console.ReadLine();
            if (jelszokitalalas == jelszo)
                Console.WriteLine("Helyes jelszó");
            else
                Console.WriteLine("Helytelen jelszó");


        }
    }
}
