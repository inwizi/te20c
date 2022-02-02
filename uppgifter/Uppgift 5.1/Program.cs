using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ord");

            Console.WriteLine("Ange en mening: ");
            string mening =Console.ReadLine();

            //Dela upp för att gitta alla ord
            //Split = sax
            string[] orden =mening.Split(' ');

            //Skriv ut alla ord på var sin rad
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }

            //Hur många ord finns i arrayen
            Console.WriteLine($"Antal prd i mening är {orden.Length}");

            //Sätt samman som en ny mening
            string nyMening = string.Join('/', orden);

            //Skriv ut en ny mening
            Console.WriteLine(nyMening);
            
        }
    }
}
