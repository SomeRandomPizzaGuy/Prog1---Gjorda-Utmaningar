using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edvin Gjervaldsaeter

namespace New_Kalkylator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabler för en TryParse
            int userMainMenuChoise;
            bool userMainMenuChoiseCheck;

            //En do-while som körs tills userMainMenuChoise är 0
            do
            {
                //Kallar på meny texten
                MainMenuText();

                //Kollar so att användaren har inte matat in fel värde och
                //förhindrar att programmet kraschar om felet är hanterat rätt
                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)   //Om userMainMenuChoiseCheck är true kör koden
                {
                    if (userMainMenuChoise == 1)   //Om userMainMenuChoise är x, kör koden
                    {
                        Addition();   //Kallar på en metod
                    }
                    else if (userMainMenuChoise == 2)
                    {
                        Subtraktion();
                    }
                    else if (userMainMenuChoise == 3)
                    {
                        Multiplikation();
                    }
                    else if (userMainMenuChoise == 0)
                    {
                        Console.WriteLine("Programmet stängs ner");
                    }
                    else
                    {
                        Console.WriteLine("Hittade inte valet");
                    }
                }
                else
                {
                    Console.WriteLine("Hittade inte det valet");
                    Console.ReadLine();
                    userMainMenuChoise = -1;
                }
            }
            while (userMainMenuChoise != 0);

            Console.ReadLine();
        }

        static void MainMenuText()
        {
            Console.Clear();
            Console.WriteLine("Simpel kalkylator");
            Console.WriteLine("Skriv in ditt val och tryck på Enter");
            Console.WriteLine("Välj 1 för Addition ( + ) ");
            Console.WriteLine("Välj 2 för Subtraktion ( - ) ");
            Console.WriteLine("Välj 3 för Multiplikation ( * ) ");
            Console.WriteLine("Välj 0 för att stänga av programmet");
            Console.Write("Ditt val: ");
        }

        static void Addition()
        {
            //Variabler för TryParse'ar
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
                Console.WriteLine("lol u dumb");
                Console.ReadLine();
            }
        }

        static void Subtraktion()
        {
            int tal1;
            int tal2;
            bool tal1Check;
            bool tal2Check;

            Console.WriteLine("Subtraktion vald");
            Console.Write("Skriv in tal1: ");

            tal1Check = int.TryParse(Console.ReadLine(), out tal1);

            Console.Write("Skriv in tal2: ");

            tal2Check = int.TryParse(Console.ReadLine(), out tal2);

            if (tal1Check && tal2Check)
            {
                Console.Write(tal1 + " - " + tal2 + " = ");
                Console.WriteLine(tal1 -= tal2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("lol u dumb");
                Console.ReadLine();
            }
        }

        static void Multiplikation()
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

            if (tal1Check && tal2Check)
            {
                Console.Write(tal1 + " * " + tal2 + " = ");
                Console.WriteLine(tal1 *= tal2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("lol u dumb");
                Console.ReadLine();
            }
        }
    }
}
