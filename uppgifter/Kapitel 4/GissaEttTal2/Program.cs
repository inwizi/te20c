using System;

namespace GissaEttTal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spelet gissa ett tal");

            //slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 51);

            //Loopa 5 gånger
            int räknare = 0;
            while (true)
            {
                 //Räkna upp varv
                 räknare++;

                 //Bryt efter 5varv
                 if (räknare >= 10)
                 {
                     break;
                 }
                  //Fråga användaren om en gissning
            Console.Write("Gissa ett tal(1-100): ");
            int gissning = int.Parse(Console.ReadLine());

            //Är gissningen rätt 
            if (gissning == slumptal)
            {
                Console.WriteLine("Bra gissat! Du gjorde på (räknare) försök");
                break;
            }

            //Jämför med slumptall
            if (gissning < slumptal)
            {
                Console.WriteLine("För Lågt!");
            }
            else
            {
                Console.WriteLine("För Högt!");
            }
            
            }
          
        }
    }
}
