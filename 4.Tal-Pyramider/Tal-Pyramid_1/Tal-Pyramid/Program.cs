using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Made by Edvin
namespace Tal_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // kod som förklarar vad programmet gör
            Console.WriteLine("Tal Pyramid");
            Console.WriteLine("Skriv in ett tal och det kommer att bli en pyramid");
            Console.Write("Mata in talet: ");

            // Kod som tillåter användaren att mata in ett tal och skapar
            // en integer som får det värdet som användaren har matat in
            int pyramidTal = int.Parse(Console.ReadLine());

            // en for loop som skapar pyramiden
            for (int i = 1; i < pyramidTal + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(pyramidTal);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
