using System;

namespace Kapitel_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna 1 till 10");

         //   for (int i = 1; i < 11; i++)
         //   {
         //      Console.WriteLine("Loop nr {i}");   
         //   }

         //Läs in en meddelande
         Console.WriteLine("Skriv ett meddelande");
         string meddelande = Console.ReadLine();
         

         // Lopa igenom meddelandet
         for (int i = 0; i < meddelande.Length; i++)
         {
             Console.WriteLine[i]);
         }
        }
    }
}
