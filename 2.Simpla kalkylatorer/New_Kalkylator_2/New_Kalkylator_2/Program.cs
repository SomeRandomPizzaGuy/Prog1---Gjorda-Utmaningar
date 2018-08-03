using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edvin Gjervaldsaeter

namespace New_Kalkylator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //En int och en bool som används i en do-While loop
            int userMenuChoise;
            bool userMenuChoiseCheck;

            do
            {
                //Console.Clear ränsar det som är skrivet i konsollen
                Console.Clear();
                Console.WriteLine("Simpel Kalkylator");
                Console.WriteLine("Välj 1 för Addition ( + )");
                Console.WriteLine("Välj 2 för Subtraktion ( - )");
                Console.WriteLine("Välj 3 för Multiplikation ( * )");
                Console.WriteLine("Välj 4 för att stänga av kalkylatorn");
                Console.Write("Skriv in ett meny val: ");

                //Denna kod används för att mata in ett tal men också kolla om användaren har skrivit rätt
                userMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMenuChoise);

                //Om userMenuChoiseCheck är true så körs koden
                if (userMenuChoiseCheck)
                {
                    if (userMenuChoise == 1)   //Om userMenuChoise är lika med x, kör koden
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
                    else if (userMenuChoise == 4)
                    {
                        Console.WriteLine("Programmet stängs ner");
                    }
                    else
                    {
                        Console.WriteLine("Hittade inte meny valet");
                        Console.ReadLine();
                    }
                }
            }
            while (userMenuChoise != 4);
            //En while loop som körs tills userMenuChoise blir 4

            Console.ReadLine();
        }

        static void Addition()
        {
            //Lite variabler som gör så att TryParse funkar
            int tal1 = -1;
            int tal2 = -1;
            bool talCheck1;
            bool talCheck2;

            Console.WriteLine("Addition vald");
            Console.Write("Skriv in tal 1: ");

            //Kollar om användaren har skrivigt in rätt och skickar ut talet om det funkade
            talCheck1 = int.TryParse(Console.ReadLine(), out tal1);

            Console.Write("Skriv in tal 2: ");

            talCheck2 = int.TryParse(Console.ReadLine(), out tal2);

            //Skriver ut numeren som användaren har matat in
            Console.Write(tal1 + " + " + tal2 + " = ");
            Console.WriteLine(tal1 += tal2);
            Console.ReadLine();
        }

        static void Subtraktion()
        {
            int tal1 = -1;
            int tal2 = -1;
            bool talCheck1;
            bool talCheck2;

            Console.WriteLine("Subtraktion vald");
            Console.Write("Skriv in tal 1: ");

            talCheck1 = int.TryParse(Console.ReadLine(), out tal1);

            Console.Write("Skriv in tal 2: ");

            talCheck2 = int.TryParse(Console.ReadLine(), out tal2);

            Console.Write(tal1 + " - " + tal2 + " = ");
            Console.WriteLine(tal1 -= tal2);
            Console.ReadLine();
        }

        static void Multiplikation()
        {
            int tal1 = -1;
            int tal2 = -1;
            bool talCheck1;
            bool talCheck2;

            Console.WriteLine("Multiplikation vald");
            Console.Write("Skriv in tal 1: ");

            talCheck1 = int.TryParse(Console.ReadLine(), out tal1);

            Console.Write("Skriv in tal 2: ");

            talCheck2 = int.TryParse(Console.ReadLine(), out tal2);

            Console.Write(tal1 + " * " + tal2 + " = ");
            Console.WriteLine(tal1 *= tal2);
            Console.ReadLine();
        }
    }
}
