using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Kalkylator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userMenuChoise = -1;
            bool menyValCheck;
            do
            {
                Console.WriteLine("Simpel Kalkylator");
                Console.WriteLine("Välj mellan tre räknesätt:");
                Console.WriteLine("1 för Addition (+)");
                Console.WriteLine("2 för Subtraktion (-)");
                Console.WriteLine("3 för Multiplikation (*)");
                Console.WriteLine("0 för att stänga av miniräknaren");

                menyValCheck = int.TryParse(Console.ReadLine(), out userMenuChoise);
                //Console.WriteLine(menyValCheck);
                //Console.WriteLine(userMenuChoise);
                //Console.ReadLine();

                if(menyValCheck)
                {
                    Console.WriteLine(userMenuChoise);

                    if (userMenuChoise == 1)
                    {
                        Addition();
                    }
                    else if (userMenuChoise == 2)
                    {
                        Subtraktion();
                    }
                    else if (userMenuChoise == 3)
                    {
                        Multiplikation();
                    }
                    else if (userMenuChoise == 0)
                    {
                        Console.WriteLine("Programmet stängs ner");
                    }
                    else
                    {
                        Console.WriteLine("Hittade inte det valet, försök igen");
                    }
                }
                else
                {
                    Console.WriteLine("Du skrev tokigt gör om, tryck på Enter");
                    Console.ReadLine();
                    Console.Clear();
                }
            } 
            while (  (menyValCheck == true  && userMenuChoise != 0 ) ||
                     (menyValCheck == false && userMenuChoise == 0 )  );

            Console.ReadLine();
        }

        static void Addition()
        {
            Console.WriteLine("Addition vald");
            Console.Write("Skriv in ditt första tal: ");

            int Tal1 = int.Parse(Console.ReadLine());

            Console.Write("Skriv in ditt andra tal: ");

            int Tal2 = int.Parse(Console.ReadLine());

            Console.Write(Tal1 + " + " + Tal2 + " = " );
            Console.WriteLine(Tal1 += Tal2);

            Console.ReadLine();

            Console.Clear();
        }

        static void Subtraktion()
        {
            Console.WriteLine("Subtraktion vald");
            Console.Write("Skriv in ditt första tal: ");

            int Tal1 = int.Parse(Console.ReadLine());

            Console.Write("Skriv in ditt andra tal: ");

            int Tal2 = int.Parse(Console.ReadLine());

            Console.Write(Tal1 + " - " + Tal2 + " = ");
            Console.WriteLine(Tal1 -= Tal2);

            Console.ReadLine();

            Console.Clear();
        }

        static void Multiplikation()
        {
            Console.WriteLine("Multiplikation vald");
            Console.Write("Skriv in ditt första tal: ");

            int Tal1 = int.Parse(Console.ReadLine());

            Console.Write("Skriv in ditt andra tal: ");

            int Tal2 = int.Parse(Console.ReadLine());

            Console.Write(Tal1 + " * " + Tal2 + " = ");
            Console.WriteLine(Tal1 *= Tal2);

            Console.ReadLine();

            Console.Clear();
        }
    }
}
