using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Tal_pyramid_1
{
    class Program
    {
        //Edvin Gjervaldsaeter

        static void Main(string[] args)
        {
            //Variabler för ett menyval
            int userMainMenuChoise = -1;
            bool userMainMenuChoiseCheck;

            //En do-while loop som körs tills userMainMenuChoise är 0
            do
            {
                Console.Clear();
                Console.WriteLine("Tal-pyramider");
                Console.WriteLine("Skriv in 1 för att börja bygga tal-pyramider");
                Console.WriteLine("Skriv in 0 för att stänga av programmet");

                //En TryParse som tillåter oss att mata in ett tal och som äver kollar om det går
                //så att programmet inte crashar
                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                //Om userMainMenuChoiseCheck är sant
                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        //Variabler för pyramiden
                        int userChoise = -1;
                        bool userChoiseCheck;

                        Console.Write("Skriv in det talet som du vill ska bli en tal-pyramid: ");

                        userChoiseCheck = int.TryParse(Console.ReadLine(), out userChoise);

                        //Om userChoiseCheck är sant
                        if (userChoiseCheck)
                        {
                            //En integer som är ett numer högre än userChoise som 
                            //är nödvändig för den första loopen
                            int userChoiseNumber = userChoise += 1;

                            userChoise -= 1;   //Minskar userChoise med 1 för av någon anledning så 
                                               //ökar userChoise med 1

                            for (int i = 1; i < userChoiseNumber; i++)   //Denna loop körs tills
                            {                                            //i är lika med userChoiseNumber
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write(userChoise);
                                }
                                Console.WriteLine(".    ." + userChoiseNumber);
                            }

                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Kan inte göra en pyramid av det du skrev in");
                            Console.ReadLine();
                        }
                    }
                    else if(userMainMenuChoise == 0)
                    {
                        Console.WriteLine("Programmet stängs ner");
                    }
                    else
                    {
                        userMainMenuChoise = -1;

                        Console.WriteLine("Gör om, gör rätt");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Gör om, gör rätt");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            Console.ReadLine();
        }
    }
}
