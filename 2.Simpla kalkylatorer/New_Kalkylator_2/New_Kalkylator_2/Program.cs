using System;
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
            int userMenuChoise = -1;
            bool userMenuChoiseCheck = true;

            while (userMenuChoise != 4 && userMenuChoiseCheck == true)
            {
                Console.Clear();
                Console.WriteLine("Simpel Kalkylator");
                Console.WriteLine("Välj 1 för Addition ( + )");
                Console.WriteLine("Välj 2 för Subtraktion ( - )");
                Console.WriteLine("Välj 3 för Multiplikation ( * )");
                Console.WriteLine("Välj 4 för att stänga av kalkylatorn");
                Console.Write("Skriv in ett meny val: ");

                userMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMenuChoise);

                if (userMenuChoise == 1)
                {
                    Console.WriteLine("Välkommen till 1");
                    Console.ReadLine();
                }
                else if (userMenuChoise == 2)
                {
                    Console.WriteLine("Välkommen till 2");
                    Console.ReadLine();
                }
                else if (userMenuChoise == 3)
                {
                    Console.WriteLine("Välkommen till 3");
                    Console.ReadLine();
                }
                else if (userMenuChoise == 4)
                {
                    Console.WriteLine("Programmet stängs ner");
                }
                else
                {
                    Console.WriteLine("Hittade inte meny valet");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("You fumped up");
            Console.ReadLine();
        }
    }
}
