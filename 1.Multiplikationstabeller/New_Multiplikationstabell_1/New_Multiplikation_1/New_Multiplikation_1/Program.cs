using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Multiplikation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplikationstabell");
            Console.WriteLine("Skriv in ett tal och få fram dens multiplikationstabell");
            Console.Write("Tal: ");

            int multiplikationstabellsTal = int.Parse(Console.ReadLine());

            Console.WriteLine(multiplikationstabellsTal);
            Console.WriteLine(multiplikationstabellsTal * 2);
            Console.WriteLine(multiplikationstabellsTal * 3);
            Console.WriteLine(multiplikationstabellsTal * 4);
            Console.WriteLine(multiplikationstabellsTal * 5);
            Console.WriteLine(multiplikationstabellsTal * 6);
            Console.WriteLine(multiplikationstabellsTal * 7);
            Console.WriteLine(multiplikationstabellsTal * 8);
            Console.WriteLine(multiplikationstabellsTal * 9);
            Console.WriteLine(multiplikationstabellsTal * 10);

            Console.ReadLine();
        }
    }
}
