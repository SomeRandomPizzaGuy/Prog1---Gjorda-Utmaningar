using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Edvin
namespace Prog1_Omprov
{
    // 1: , decimal

    // 2: 

    // 3: En while-loop körs tills argumentet är inte längre sant
    // och en do-while-loop kör koden minst en gång och sedan
    // beter sig som en vanlig while-loop.

    // 4: 

    // 5:

    // 6: En klass är som en ritning som kan användas flera gånger
    // och ett object är som ett idividuelt hus som har skapats med 
    // hjälp av en klass, ett object kan bli idividuelt modifierad
    // utan att klassen eller andra object ändras.

    class Program
    {
        static void Main(string[] args)
        {
            // Gör så att vi kommer in i while loopen direkt
            int userMainMenuInput = 0;

            // En while loop som körs tills man matar in numeret 6
            while (userMainMenuInput != 6)
            {
                // Ränsar texten i consolen
                Console.Clear();

                // En metod med instruktionerna
                MainMenuText();

                // Denna kod tillåter oss att mata in ett tal
                // genom att byta ut talet som userMainMenuInput har
                userMainMenuInput = int.Parse(Console.ReadLine());

                // En switch sats som använder userMainMenuInput som menyval
                switch (userMainMenuInput) {
                    case 1:
                        {
                            // Ropar på metoden Addition
                            Addition();
                        }
                        break;

                    case 2:
                        {
                            Subtraktion();
                        }
                        break;

                    case 3:
                        {
                            Multiplikation();
                        }
                        break;

                    case 4:
                        {
                            Division();
                        }
                        break;

                    case 5:
                        {
                            Medelvärde();
                        }
                        break;

                        // Eftersom denna case är numer 6 så hoppar vi ut ur
                        // while loopen och avslutar programmet för att
                        // while loopen går tills userMainMenuInput är 6
                    case 6:
                        {
                            Console.WriteLine("Programmet stängs av.");
                        }
                        break;
                }
                Console.ReadLine();
            }
        }

        static void MainMenuText()
        {
            Console.WriteLine("Miniräkrare");
            Console.WriteLine("Välj 1 för Addition ( + )");
            Console.WriteLine("Välj 2 för Subtraktion ( - )");
            Console.WriteLine("Välj 3 för Multiplikation ( * )");
            Console.WriteLine("Välj 4 för Division ( / )");
            Console.WriteLine("Välj 5 för att räkna ut ett medel värde på 5 tal");
            Console.WriteLine("Välj 6 för att avsluta programmet");
        }

        static void Addition()
        {
            Console.Write("Tal1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal2: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine(tal1 + " + " + tal2 + " = " + (tal1 + tal2));
        }

        static void Subtraktion()
        {
            Console.Write("Tal1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal2: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine(tal1 + " - " + tal2 + " = " + (tal1 - tal2));
        }

        static void Multiplikation()
        {
            Console.Write("Tal1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal2: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine(tal1 + " * " + tal2 + " = " + (tal1 * tal2));
        }

        static void Division()
        {
            Console.Write("Tal1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal2: ");
            int tal2 = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(tal1 + " / " + tal2 + " = " + (tal1 / tal2));
            }
            catch (DivideByZeroException DivideByZero)
            {
                Console.WriteLine(DivideByZero);
            }
        }

        static void Medelvärde()
        {
            Console.WriteLine("Den här räkrar ut medelvärdet på 5 tal");
            Console.Write("Tal1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal2: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.Write("Tal3: ");
            int tal3 = int.Parse(Console.ReadLine());
            Console.Write("Tal4: ");
            int tal4 = int.Parse(Console.ReadLine());
            Console.Write("Tal5: ");
            int tal5 = int.Parse(Console.ReadLine());

            Console.WriteLine((tal1 + tal2 + tal3 + tal4 + tal5) / 5);
        }
    }
}
