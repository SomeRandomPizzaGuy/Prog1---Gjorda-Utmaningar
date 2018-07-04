using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utmaning1_Multiplikationstabellen_Edvin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriver ut en hel rad och hoppar ned
            Console.WriteLine("Multiplikationstabeller");

            // Skriver ut en text men som inte hoppar ur
            Console.Write("Skriv in ett valfrit heltal:");

            // Denna kod gör så att man kan mata in tal och bokstäver
            int Tal1 = int.Parse(Console.ReadLine());

            // Simpel for loop som gångrar det inmatade talet från 1 till 10
            for (int Tal2 = 1; Tal2 < 11; Tal2++)
            {
                Console.WriteLine(Tal1 * Tal2);
            }

            // Stoppar programmet från att stänga ned sig automatiskt när koden har körts
            Console.ReadLine();
        }
    }
}
