using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_Kalkylator_Edvin
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoiceRäknesätt = 0;

            // En while loop som körs tills argumentet är inte sant
            while (userChoiceRäknesätt != 4)
            {
                
                // Text som förklarar vad som programet gör och hur det funkar
                Console.WriteLine("Simpel Kalkylator");
                Console.WriteLine("Välj det räknesätt som du vill använda:");
                Console.WriteLine("Räknesätt:");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtration");
                Console.WriteLine("3: Multiplikation");
                Console.WriteLine("4: Stäng ner programmet");

                // denna kod gör så att vi kan mata in ett tal och
                //  så att programmet använder det valda talet
                userChoiceRäknesätt = int.Parse(Console.ReadLine());

                // try gör så att programmet kan plocka upp probem
                // och hantera dem utan att programmet krachar
                // som om man matar in en bokstav istället för en sifra
                try
                {
                    // switch tar upp ett värde och kollar om det stämmer
                    // med något, om det inmatade värdet stämmer med någonting
                    // så körs den koden som var inom den case'en som stämde
                    switch (userChoiceRäknesätt)
                    {
                        case 1:
                            try
                            {
                                // en kod som anropar en metod
                                // denna kok anropar metoden Addition
                                Addition();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Felaktigt tal inmatat: " + ex.Message);
                            }
                            break;

                        case 2:
                            try
                            {
                                Subtration();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case 3:
                            try
                            {
                                Multiplikation();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case 4:
                            Console.WriteLine("Programet stängs ner");
                            break;

                        default:
                            Console.WriteLine("Inget stämde");
                            break;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }
        }

        // metoder lagrade för senare användning
        static void Addition()
        {
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Summan är: " + (tal1 + tal2));
        }

        static void Subtration()
        {
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Summan är: " + (tal1 - tal2));
        }

        static void Multiplikation()
        {
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Summan är: " + (tal1 * tal2));
        }
    }
}
