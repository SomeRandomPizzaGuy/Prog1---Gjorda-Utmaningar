using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edvin Gjervaldsaeter

namespace New_Multiplikationstabell_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplikationstabell");
            Console.WriteLine("Skriv in ett tal och få det talets multiplikationstabell");
            Console.Write("Skriv in ett valfritt heltal: ");

            //Denna kod tilloter oss att mata in ett tal genom att omdekladera 
            //multiplikationstabellInputTal till ett tal som användaren skrev in
            int multiplikationstabellInputTal = int.Parse(Console.ReadLine());

            //En for loop som körs tills loopTal är lika med 11 då loopen hoppar ur
            for(int loopTal = 1; loopTal < 11; loopTal++)
            {
                //Skriver ut vad multiplikationstabellInputTal gånger loopTal blir
                Console.WriteLine(multiplikationstabellInputTal + " * " + loopTal + " = " + loopTal * multiplikationstabellInputTal);
            }

            Console.ReadLine();
        }
    }
}
