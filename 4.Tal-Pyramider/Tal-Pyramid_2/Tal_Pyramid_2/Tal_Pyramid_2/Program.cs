﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Made By Edvin

namespace Tal_Pyramid_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabler för en TryParse
            int userMainMenuChoise = -1;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("TalPyramid");
                Console.WriteLine("Skriv in 1 för att bygga en tal pyramid");
                Console.WriteLine("Skriv in 0 för att stänga av programet");

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
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Du skrev tokight, försök igen");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            Console.ReadLine();
        }

        static void PyramidByggare()
        {
            int userNumberInput;
            bool userNumberInputCheck;

            Console.Write("Skriv in ett tal och så byggs det en pyramid utav det talet: ");

            userNumberInputCheck = int.TryParse(Console.ReadLine(), out userNumberInput);

            if (userNumberInputCheck)
            {
                if (userNumberInput > 0)
                {
                    for (int i = 1; i < userNumberInput + 1; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(userNumberInput);
                        }
                        Console.WriteLine();
                    }
                }
                else if (userNumberInput < 0)
                {
                    for (int i = -1; i > userNumberInput - 1; i--)
                    {
                        for (int j = 0; j > i; j--)
                        {
                            Console.Write(userNumberInput);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Programet kan inte bygga en pyramid av: " + userNumberInput);
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
