using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edvin Gjervaldsaeter

namespace New_Kalkylator_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabler för en TryParse
            int userMainMenuChoise;
            bool userMainMenuChoiseCheck;

            do   //En do-while loop som körs tills userMaonMenuChoise är lika med 0
            {
                Console.Clear();
                Console.WriteLine("Simpel Kalkylator");
                Console.WriteLine("Skriv in ett val och tryck på Enter");
                Console.WriteLine("Skriv in 1 för Addition ( + ) ");
                Console.WriteLine("Skriv in 2 för Subtraktion ( - ) ");
                Console.WriteLine("Skriv in 3 för Multiplikation ( * ) ");
                Console.WriteLine("Skriv in 0 för att stänga av miniräknaren");
                Console.Write("Ditt val: ");

                //En TryParse för att se om användaren har skrivigt rätt
                // och ser till att programmet inte kraschar
                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)   //Om userMainMenuChoiseCheck är sant, kör koden
                {
                    if (userMainMenuChoise == 1)   //Om userMainMenuChoise är samma som x, kör koden
                    {
                        Addition();   //Tillkallar en metod
                    }
                    else if (userMainMenuChoise == 2)
                    {
                        Subtraktion();
                    }
                    else if (userMainMenuChoise == 3)
                    {
                        Multiplikaion();
                    }
                    else if (userMainMenuChoise == 0)
                    {
                        Console.WriteLine("Programmet stängs ner");
                    }
                    else
                    {
                        Console.WriteLine("Gör om, gör rätt");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Hittade ej valet");
                    userMainMenuChoise = -1;
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);
        }

        static void Addition()
        {
            //Variabler för två TryParse'ar
            int tal1;
            int tal2;
            bool tal1Check;
            bool tal2Check;

            Console.WriteLine("Addition vald");

            Console.Write("Skriv in tal1: ");

            tal1Check = int.TryParse(Console.ReadLine(), out tal1);

            Console.Write("Skriv in tal2: ");

            tal2Check = int.TryParse(Console.ReadLine(), out tal2);

            if (tal1Check && tal2Check)
            {
                Console.Write(tal1 + " + " + tal2 + " = ");
                Console.WriteLine(tal1 += tal2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Du skrev tokigt! Gör om, gör rätt");
                Console.ReadLine();
                Addition();
            }
        }

        static void Subtraktion()
        {
            int tal1;
            int tal2;
            bool tal1Check;
            bool tal2Check;

            Console.WriteLine("Subrtaktion vald");

            Console.Write("Skriv in tal1: ");

            tal1Check = int.TryParse(Console.ReadLine(), out tal1);

            Console.Write("Skriv in tal2: ");

            tal2Check = int.TryParse(Console.ReadLine(), out tal2);

            Console.Write(tal1 + " - " + tal2 + " = ");
            Console.WriteLine(tal1 -= tal2);
            Console.ReadLine();
        }

        static void Multiplikaion()
        {
            int tal1;
            int tal2;
            bool tal1Check;
            bool tal2Check;

            Console.WriteLine("Multiplikation vald");

            Console.Write("Skriv in tal1: ");

            tal1Check = int.TryParse(Console.ReadLine(), out tal1);

            Console.Write("Skriv in tal2: ");

            tal2Check = int.TryParse(Console.ReadLine(), out tal2);

            Console.Write(tal1 + " * " + tal2 + " = ");
            Console.WriteLine(tal1 *= tal2);
            Console.ReadLine();
        }
    }
}
