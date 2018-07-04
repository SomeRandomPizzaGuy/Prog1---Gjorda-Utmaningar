using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Made by Edvin
namespace Meningskonverterare_Edvin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kod som förklarar var programmet gör för användaren
            Console.WriteLine("Meningskonverterare");
            Console.WriteLine("Välj 1 för att konvertera till små bokstäver");
            Console.WriteLine("Välj 2 för att konvertera till stora bokstäver");
            Console.WriteLine("Välj 3 för att stänga ner programmet");

            string inputText = "WjEfjS";
            inputText.ToLower();
            inputText.ToUpper();

            // Kod som tillåter användaren att mata in ett tal som meny val för switch satsen längre ned
            int userChoise = int.Parse(Console.ReadLine());

            // Kod som kollar om använaren har matat in tal 1 eller 2
            if (userChoise == 1 || userChoise == 2)
            {
                Console.Write("Mata in den text som du vill konvertera: ");

                // Denna kod tillåter en användare att mata in meningen som ska konverteras
                // genaom att vi ändrar "inputText" till det vi skriver in
                inputText = Console.ReadLine();
            }
            
            // En simpel switch sats för menyvalen
            switch(userChoise)
            {
                case 1:
                    {
                        // Kod som min farsa ville lägga in (Jag behövde hans hjälp för att jag var fast och han ville att prova lite kod)
                        // En if sats som koller om meningen som använderen har skrivit in är längre än 8 karaktärer
                        // och sedan skriver ut de 2 karaktärer som kommer efter de första 8 karaktärerna
                        if (inputText.Length > 8)
                        {
                            Console.Write("Efter 8 täken så är de följande två karaktärerna: ");
                            Console.WriteLine(inputText.Substring(8, 2));
                        }
                        else
                        {
                            Console.WriteLine("Du har mindre än 8 karaktärer i meningen: " + inputText);
                        }

                        // Konverterar den inmatade meningern till små bokstäver
                        Console.WriteLine(inputText.ToLower());
                        break;
                    }

                case 2:
                    {
                        if (inputText.Length > 8)
                        {
                            Console.Write("Efter 8 täken så är de två följande karaktärerna: ");
                            Console.WriteLine(inputText.Substring(8, 2));
                        }
                        else
                        {
                            Console.WriteLine("Du har mindre än 8 karaktärer i meningen: " + inputText);
                        }

                        // Konverterar den inmatade meningen till stora bokstäver
                        Console.WriteLine(inputText.ToUpper());
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Programmet stängs ner");
                        break;
                    }
            }
            
            Console.ReadLine();
        }
    }
}
