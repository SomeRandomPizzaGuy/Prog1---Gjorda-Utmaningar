using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Edvin Gjervaldsaeter

namespace New_Meningskonverterare_1
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
                Console.Clear();
                Console.WriteLine("Meningskonverterare");
                Console.WriteLine("Välj 1 för att konvertera en mening till bara små bokstäver");
                Console.WriteLine("Välj 2 för att konvertera en mening till bara stora bokstäver");
                Console.WriteLine("Välj 0 för att avsluta");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        SmåBokstavsKonverterare();
                    }
                    else if (userMainMenuChoise == 2)
                    {
                        StoraBokstavsKonverterare();
                    }
                    else if(userMainMenuChoise == 0)
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
                    Console.WriteLine("Hittade inte valet");
                    Console.ReadLine();

                    userMainMenuChoise = -1;
                }
            }
            while (userMainMenuChoise != 0);

            Console.ReadLine();
        }

        static void SmåBokstavsKonverterare()
        {
            string userTextInput;

            Console.WriteLine("Små bokstäver vald");
            Console.Write("Skriv in din mening och tryck på Enter: ");

            //Tillåter användaren att mata in sin mening
            userTextInput = Console.ReadLine();

            //Konverterar alla bokstäver till små med hjälp av .ToLower
            userTextInput = userTextInput.ToLower();

            Console.WriteLine(userTextInput);
            Console.ReadLine();
        }

        static void StoraBokstavsKonverterare()
        {
            string userTextInput;

            Console.WriteLine("Stora bokstäver vald");
            Console.Write("Skriv in din mening och tryck på Enter: ");

            userTextInput = Console.ReadLine();

            userTextInput = userTextInput.ToUpper();

            Console.WriteLine(userTextInput);
            Console.ReadLine();
        }
    }
}
