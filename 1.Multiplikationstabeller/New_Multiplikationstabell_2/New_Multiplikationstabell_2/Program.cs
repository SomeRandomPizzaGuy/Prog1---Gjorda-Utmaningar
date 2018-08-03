using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edvin Gjervaldsaeter

namespace New_Multiplikationstabell_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplikationstabell");
            Console.WriteLine("Skriv in ett tal för att få fram talets multiplikationstabell");
            Console.Write("Skriv in ett valfritt hel tal: ");

            //Denna kod tilloter oss att omdekladera multiplikationstabellInputTal 
            //till det tal som användarer skriver in
            int multiplikationstabellInputTal = int.Parse(Console.ReadLine());

            //En for loop som körs tills loopTal är 11 då den avslutas
            for (int loopTal = 1; loopTal < 11; loopTal++)
            {
                //Skriver ut multiplikationstabellInputTal men samtidigt gångrar det talet med loopTal
                Console.WriteLine(multiplikationstabellInputTal * loopTal);
            }

            Console.ReadLine();
        }
    }
}
