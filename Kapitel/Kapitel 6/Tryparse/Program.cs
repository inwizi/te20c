using System;

namespace Tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal");

            //Slumpgenerator
            Random generator = new Random();

            //slumpa fram ett tal mellan 1 och 100
            int slumptal = generator.Next(1,101); //1,100
            int slumptal2 = generator.Next(1,11); //1,10

            // Be spelaren att gissa ett tal
            Console.Write("Gissa ett tal från (1-100)): ");
            string gissning = Console.ReadLine();

            //Försök översätta det inmatade till ett tal
            int gissningTal = 0;
            bool korrekt = false;

            //Loop för att tvinga spelaren för att mata in något korrekt
            while(korrekt !=true)
            {
                Console.WriteLine("Du måste mata in ett tal (1,100)");
                gissning = Console.ReadLine();
                korrekt = int.TryParse(gissning, out gissningTal);
            }
            
            
            //Var gissningen korrekt
            if (gissningTal == slumptal)
            {
                Console.WriteLine("Du gissade korrekt");
            }
            else
            {
                Console.WriteLine("Du gissade fel");
            }
        }
    }
}
