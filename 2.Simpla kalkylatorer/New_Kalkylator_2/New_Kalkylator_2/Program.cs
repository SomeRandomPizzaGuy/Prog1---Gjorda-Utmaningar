﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Kalkylator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userMenuChoise;
            bool userMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("Simpel Kalkylator");
                Console.WriteLine("Välj 1 för Addition ( + )");
                Console.WriteLine("Välj 2 för Subtraktion ( - )");
                Console.WriteLine("Välj 3 för Multiplikation ( * )");
                Console.WriteLine("Välj 4 för att stänga av kalkylatorn");
                Console.Write("Skriv in ett meny val: ");

                userMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMenuChoise);

                if (userMenuChoiseCheck)
                {
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
                    else if (userMenuChoise == 4)
                    {
                        Console.WriteLine("Programmet stängs ner");
                    }
                    else
                    {
                        Console.WriteLine("Hittade inte meny valet");
                    }
                }
            }
            while (userMenuChoise != 4);

            Console.ReadLine();
        }

        static void Addition()
        {
            int tal1 = -1;
            int tal2 = -1;
            bool talCheck1;
            bool talCheck2;

            Console.WriteLine("Addition vald");
            Console.Write("Skriv in tal 1: ");

            talCheck1 = int.TryParse(Console.ReadLine(), out tal1);

            Console.Write("Skriv in tal 2: ");

            talCheck2 = int.TryParse(Console.ReadLine(), out tal2);

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
