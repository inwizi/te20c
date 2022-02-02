using System;

namespace Kapitel_4_program
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hej på dig";

            //skriv hela stränge (string)
            Console.WriteLine(meddelande);

            // skriv ut första bokstaven "h"
            Console.WriteLine(meddelande[0]);

            //Skriv ut sista tecknet '!'
            Console.WriteLine(meddelande[10]);

            char bokstav = 'Z';

            //skriv ut alla tecken
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
