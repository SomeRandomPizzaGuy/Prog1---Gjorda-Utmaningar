using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edvin Gjervaldsaeter

namespace New_Multiplikation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplikationstabell");
            Console.WriteLine("Skriv in ett tal och få fram dens multiplikationstabell");
            Console.Write("Tal: ");

            //Kod som tillåter oss att mata in ett tal
            //Parse omdekladerar talet som användaren skriver in
            int multiplikationstabellsTal = int.Parse(Console.ReadLine());

            Console.WriteLine(multiplikationstabellsTal);
            Console.WriteLine(multiplikationstabellsTal * 2);   //Skriver ut talen och gångrar dem upp till gånger tio
            Console.WriteLine(multiplikationstabellsTal * 3);
            Console.WriteLine(multiplikationstabellsTal * 4);
            Console.WriteLine(multiplikationstabellsTal * 5);
            Console.WriteLine(multiplikationstabellsTal * 6);
            Console.WriteLine(multiplikationstabellsTal * 7);
            Console.WriteLine(multiplikationstabellsTal * 8);
            Console.WriteLine(multiplikationstabellsTal * 9);
            Console.WriteLine(multiplikationstabellsTal * 10);

            Console.ReadLine();   //Har den här readlinen så att programmet inte stängs av direkt
        }
    }
}
