using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Multiplikationstabell_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplikationstabell");
            Console.WriteLine("Skriv in ett tal och få det talets multiplikationstabell");
            Console.Write("Skriv in ett valfritt heltal: ");

            int multiplikationstabellInputTal = int.Parse(Console.ReadLine());

            for(int loopTal = 1; loopTal < 11; loopTal++)
            {
                Console.WriteLine(multiplikationstabellInputTal + " * " + loopTal + " = " + loopTal * multiplikationstabellInputTal);
            }

            Console.ReadLine();
        }
    }
}
