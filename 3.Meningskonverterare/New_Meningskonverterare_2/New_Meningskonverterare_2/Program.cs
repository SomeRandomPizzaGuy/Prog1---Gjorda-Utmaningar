using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edvin Gjervaldsaeter

namespace New_Meningskonverterare_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userMenuChoise = -1;
            bool userMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("Meningskonverterare");
                Console.WriteLine("Välj 1 för att konvertera alla bokstäver i en mening till små bokstäver");
                Console.WriteLine("Välj 2 för att konvertera alla bökstäver i en mening till stora bokstäver");
                Console.WriteLine("Välj 0 för att stänga av programmet");

                userMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMenuChoise);

                if (userMenuChoiseCheck)
                {
                    if(userMenuChoise == 1)
                    {
                        SmåBokstavsKonverterare();
                    }
                    else if (userMenuChoise == 2)
                    {
                        StorBokstävsKonverterare();
                    }
                    else if (userMenuChoise == 0)
                    {
                        Console.WriteLine("Programmet stängs ner");
                    }
                    else
                    {
                        Console.WriteLine("Hittade inte det valet");
                        Console.ReadLine();

                        userMenuChoise = -1;
                    }
                }
                else
                {
                    Console.WriteLine("Hittade inte det valet");
                    Console.ReadLine();

                    userMenuChoise = -1;
                }
            }
            while (userMenuChoise != 0);

            Console.ReadLine();
        }

        static void SmåBokstavsKonverterare()
        {
            string userStringInput;

            Console.WriteLine("Småbokstäver vald");
            Console.Write("Skriv in den mening som du vill konvertera: ");

            userStringInput = Console.ReadLine();

            userStringInput = userStringInput.ToLower();

            Console.WriteLine(userStringInput);
            Console.ReadLine();
        }

        static void StorBokstävsKonverterare()
        {
            string userStringInput;

            Console.WriteLine("Storabokstäver vald");
            Console.Write("Skriv in den mening som du vill konvertera: ");

            userStringInput = Console.ReadLine();

            userStringInput = userStringInput.ToUpper();

            Console.WriteLine(userStringInput);
            Console.ReadLine();
        }
    }
}
