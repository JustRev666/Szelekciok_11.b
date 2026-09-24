using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy tetszőleges számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam%3 == 0)
            {
                Console.WriteLine($"{szam} osztható 3-mal maradék nélkül");
            }
            else
            {
                Console.WriteLine($"{szam} nem osztható 3-mal");
            }
            Console.ReadKey();  
        }
    }
}
