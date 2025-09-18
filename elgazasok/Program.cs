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
            Console.Write("Kérlek adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
                Console.WriteLine("Páros");
            else
                Console.WriteLine("Páratlan");

        }
    }
}
