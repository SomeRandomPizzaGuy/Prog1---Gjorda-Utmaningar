using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

            bool mainMenuLoop = true;
            while (mainMenuLoop)
            {
                MainMenu();
            }

            Console.ReadLine();
        }

        private static void MainMenu()
        {
            Console.WriteLine("Personregister");
            Console.WriteLine("Välj 1 för att se alla personer som finns i listan.");
            Console.WriteLine("Välj 2 för att lägga till en person i registret.");
            Console.WriteLine("Välj 3 för att söka efter ett namn och få mer info om den personen.");
            Console.WriteLine("Skriv menu för att få upp denna meny igen.");
            Console.WriteLine("Skriv 0 för att avsluta programmet.");
            Console.WriteLine("");

            int UserChoice = 5;

            while (UserChoice != 0)
            {
                UserChoice = int.Parse(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1:
                        Console.WriteLine("Du valde 1");
                        break;

                    case 2:
                        Console.WriteLine("Du valde 2");
                        break;

                    case 3:
                        Console.WriteLine("Du valde 3");
                        break;

                    case 4:
                        MainMenu();
                        break;

                    case 0:
                        Console.WriteLine("Programmet stängs ner");
                        break;

                    default:
                        Console.WriteLine("Felaktig input");
                        MainMenu();
                        break;
                }
            }
        }
    }
}
