using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Made by Edvin
namespace Hangman
{
    class Program
    {
        // List-objekt med ord (List är en dynamisk array)
        static List<string> Lista = new List<string>();


        static void Main(string[] args)
        {
            // Metodanrop till AddWords med Lista som indata
            // Metoden lägger till ord(strängar) i listan
            AddWords(Lista);

            // Slumpmässigt tilldelar ett ord med hjälp av GetRandomWord i variabeln mittOrd
            string mittOrd = GetRandomWord(Lista);


            Console.WriteLine("Wellcome to Hangman!");

            // Try-catch för felhantering(så programmet inte kraschar)
            try
            {
                //PrintWord(Lista);

                Game(Lista);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            //Game(Lista);


            Random r = new Random();
            

            Console.Write(r.Next(0, 10));
            Console.Write(r.Next(0, 10));
            Console.WriteLine(r.Next(0, 10));

            Console.WriteLine();

            Console.ReadLine();
        }

        // Startar spelet
        private static void Game(List<string> lista)
        {
            // Antal gissningar spelaren har på sig
            int AntGisningar = 10;
            char UserLetterInput;   // Lagrar spelarens inmatningsvärde

            // slumpar ett ord och tilldelar ordet till variabeln
            string RndOrd = GetRandomWord(lista);
            // För varje ogissad bokstav håller den ett "_"
            string GissatOrd = "";

            // Så länge i är lägre än längden på RndOrd
            for (int i = 0; i < RndOrd.Length; i++)
            {
                // Lägg till ett understreck till GissatOrd
                GissatOrd += "_";
            }

            // Så länge spelaren har gissningar kvar och ordet inte är gissat
            while (AntGisningar > 0 && RndOrd != GissatOrd)
            {
                // Hämta en gissning från spelaren
                UserLetterInput = GetOneChar();
                // Jämför ord
                CompareWord(RndOrd, UserLetterInput, ref GissatOrd);
                AntGisningar--; // drar bort en gissning
                // Skriver ut GissatOrd
                Console.WriteLine(GissatOrd);
            }

            // Om Rnd och GissatOrd är lika
            if (RndOrd == GissatOrd)
            {
                // Rätt svar
                Console.WriteLine("Gratis, du gissade rätt! Ordet var: " + RndOrd);
            }
            else
            {
                // Inte rätt svar
                Console.WriteLine("Tyvärr, det rätta rodet var: " + RndOrd);
                Console.WriteLine("Antal rätt: " + GissatOrd);
            }
            Console.ReadLine();
        }

        // Byter ut en bokstav på en specifik plats
        private static string ReplaceAt(string value, int index, char newchar)
        {
            if (value.Length <= index)
                return value;
            else
                return string.Concat(value.Select((c, i) => i == index ? newchar : c));
            //                       Om i är samma som index, byt ut till newChar, annars håll kvar c
        }

        // Jämför inmatad bokstav med ordet och byter ut "_" om det är korrekt
        private static void CompareWord(string rndOrd, char userLetterInput, ref String gissatOrd)
        {
            int indexx = 0;
            // Konverterar gissatOrd till en char array
            char[] array = gissatOrd.ToCharArray();
            
            // Så länge indexx är lägre än längden på rndOrd
            while (indexx < rndOrd.Length)
            {
                // Om användarens bokstav finns i rndOrd
                if (userLetterInput == rndOrd[indexx])
                {
                    //array[indexx] = userLetterInput;
                    // Byt ut "_" mot bokstaven
                    gissatOrd = ReplaceAt(gissatOrd, indexx, userLetterInput);
                }
                // addera 1 till indexx
                indexx++;
            }

            //for (int i = 0; i < rndOrd.Length; i++)
            //{
                
            //}
        }

        // Meddelar användaren om en gissning,
        // sparar gissningen i "S" och returnerar gissningen
        private static char GetOneChar()
        {
            String S;
            Console.Write("Skriv in den bokstaven som du vill gissa med: ");
            S = Console.ReadLine();
            return S[0];
        }

        // En metod som returnerar ett slumpat ord från listan
        private static string GetRandomWord(List<string> lista)
        {
            // Skapar en tom variabel
            int index;
            // Skapar ett Random objekt(för att slumpa tal)
            Random r = new Random();
            // Slumpar ett tal mellan 0 och längden på listan och sparar värdet i index
            index = r.Next(0, lista.Count - 1);

            // Returnerar ett ord i listan baserat på index
            return Lista[index];
        }


        private static void PrintWord(List<string> lista)
        {
            int ImittTal = 1;
            String SmittTal;

            while (ImittTal != 0)
            {
                Console.WriteLine("Ange tal mellan 1 och " + Lista.Count.ToString());
                SmittTal = (Console.ReadLine());
                ImittTal = int.Parse(SmittTal);
                Console.WriteLine(GetRandomWord(lista));
                //Console.WriteLine(lista[ImittTal - 1]);
            };
        }

        // Lägger till ord i den globala listan
        private static void AddWords(List<string> lista)
        {
            // Använder List-objektets "Add" metod för att lägga till ord
            lista.Add("Katt");
            lista.Add("Hund");
            lista.Add("Ost");
            lista.Add("Potatis");
            lista.Add("Soffa");
        }
    }
}
