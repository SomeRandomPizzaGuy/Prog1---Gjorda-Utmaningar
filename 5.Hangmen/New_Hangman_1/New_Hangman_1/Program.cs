using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Made by Edvin

namespace New_Hangman_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userMainMenuChoise = -1;
            bool userMainMenuChoiseCheck;
            bool replay = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Välkomen till Hangman");

                if (replay)
                {
                Console.WriteLine("Vill du försöka igen?");
                }

                Console.WriteLine("Skriv in 1 för att börja spela");
                Console.WriteLine("Skriv in 0 för att stänga av spelet");
                Console.Write("Skriv in ditt val: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);
            
                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        replay = true;

                        Game();
                    }
                    else if (userMainMenuChoise == 0)
                    {

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

                    Console.WriteLine("Du skrev tokigt, försök igen");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            Console.WriteLine("Programmet stängs ner");
            Console.ReadLine();
        }

        static void Game()
        {
            Random randomGameNumber = new Random();
            string[] guessWords = new string[] {"Hund", "Katta", "Lejonen", "Björnide", "Drakar", "Apelsiner", "Lo"};
            string[] guessWordsS

            int randomChosenWord = randomGameNumber.Next(0, guessWords.Count() - 1);

            Console.WriteLine(guessWords.Count().ToString());
            Console.WriteLine(guessWords[randomChosenWord]);
            Console.WriteLine(guessWords[randomChosenWord].Count().ToString());

            for (int i = 0; i < guessWords[randomChosenWord].Count(); i++)
            {
                Console.Write(" _");
            }
            Console.WriteLine();

            Console.WriteLine(randomChosenWord);
            Console.ReadLine();
        }

        static void Example()
        {
            // Instantiate random number generator using system-supplied value as seed.
            Random rand = new Random();
            // Generate and display 5 random byte (integer) values.
            byte[] bytes = new byte[5];
            rand.NextBytes(bytes);
            Console.WriteLine("Five random byte values:");
            foreach (byte byteValue in bytes)
                Console.Write("{0, 5}", byteValue);
            Console.WriteLine();
            // Generate and display 5 random integers.
            Console.WriteLine("Five random integer values:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,15:N0}", rand.Next());
            Console.WriteLine();
            // Generate and display 5 random integers between 0 and 100.//
            Console.WriteLine("Five random integers between 0 and 100:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N0}", rand.Next(101));
            Console.WriteLine();
            // Generate and display 5 random integers from 50 to 100.
            Console.WriteLine("Five random integers between 50 and 100:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N0}", rand.Next(50, 101));
            Console.WriteLine();
            // Generate and display 5 random floating point values from 0 to 1.
            Console.WriteLine("Five Doubles.");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N3}", rand.NextDouble());
            Console.WriteLine();
            // Generate and display 5 random floating point values from 0 to 5.
            Console.WriteLine("Five Doubles between 0 and 5.");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N3}", rand.NextDouble() * 5);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Random rnd = new Random();
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                                "Vanya", "Samuel", "Koani", "Volodya",
                                "Prince", "Yiska" };
            string[] femalePetNames = { "Maggie", "Penny", "Saya", "Princess",
                                  "Abby", "Laila", "Sadie", "Olivia",
                                  "Starlight", "Talla" };

            // Generate random indexes for pet names.
            int mIndex = rnd.Next(malePetNames.Length);
            int fIndex = rnd.Next(femalePetNames.Length);

            // Display the result.
            Console.WriteLine("Suggested pet name of the day: ");
            Console.WriteLine("   For a male:     {0}", malePetNames[mIndex]);
            Console.WriteLine("   For a female:   {0}", femalePetNames[fIndex]);

            Console.ReadLine();
        }
    }
}
