using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Made by Edvin

namespace Tal_Pyramid_3
{
    class Program
    {
        static void Main(string[] args)   //Denna är en Work in progress
        {
            int userMainMenuChoise = -1;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("Tal Pyramid");
                Console.WriteLine("Skriv in 1 för att bygga en tal pyramid");
                Console.WriteLine("Skriv in 0 för att stänga av programet");
                Console.Write("Skriv in ditt val här: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        PyramidByggare();
                    }
                    else if (userMainMenuChoise == 0)
                    {
                        Console.WriteLine("Programet stängs ner");
                    }
                    else
                    {
                        Console.WriteLine("Hittade inte det valet");
                        Console.Write("Tryck på enter för att fortsätta");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Du skrev tokigt, försök igen");
                    Console.Write("Tryck på enter för att fortsätta");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            Console.ReadLine();
        }

        static void PyramidByggare()
        {
            int userChoise;
            bool userChoiseCheck;

            Console.WriteLine("Skriv in ett heltal och så byggs det en pyramid av det talet");
            Console.Write("Skriv in ditt tal här: ");

            userChoiseCheck = int.TryParse(Console.ReadLine(), out userChoise);

            if (userChoiseCheck)
            {
                if (userChoise > 0)
                {
                    for (int i = 0; i < userChoise; i++)
                    {
                        for (int spaceI = (userChoise - i) - 2; spaceI >= 0; spaceI--)
                        {
                            Console.Write(" ");
                        }

                        for (int j = -1; j < i; j++)
                        {
                            Console.Write(userChoise + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (userChoise < 0)
                {
                    for (int i = 0; i > userChoise; i--)
                    {
                        //for (int spaceI = (userChoise + i) + 2; spaceI <= 0; spaceI++)
                        //{
                        //    Console.Write(" ");
                        //}

                        for (int j = 1; j > i; j--)
                        {
                            Console.Write(userChoise + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (userChoise > -1 && userChoise < 1)
                {
                    Console.WriteLine("Kan inte bygga en pyramid av " + userChoise);
                }
                else
                {
                    Console.WriteLine("Kan inte hitta det värdet");
                }
            }
            else
            {
                Console.WriteLine("Du skrev tokigt, försök igen");
            }
            Console.ReadLine();
        }
    }
}
