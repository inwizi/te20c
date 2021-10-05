using System;

namespace uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren om ålder
            Console.WriteLine("Hur gammal är du?(heltal)");
            int ålder = int.Parse(Console.ReadLine());

            // Om ålder är större än 18 du får ta körkort!
            if (ålder >= 18)
            {
                Console.WriteLine("Du får ta körkort");

            }
            
            // Om ålder är 15 eller högre "Du får ta körkort
            if (ålder >= 15)
           
            {
                 Console.WriteLine("Du får ta moppekort");
                
            }
            // Fråga användaren "Vad heter ABBAS senaste låt?"
           Console.WriteLine("Vad heter ABBAS senaste låt?");
           string låt = Console.ReadLine();
           
           //Är svar korrekt
           if (låt == "Voyage" || låt == "voyage")
           {
               Console.WriteLine("Bra svarat");
           }
           else
           {
               Console.WriteLine("Fel! Albumet Heter Voyage");
           }  
           //Sista TP-Fråga
           Console.Write("Vem missade straffen i matchen England-Frankrike");
           //Läs in och tvinga till små bokstäver: 
           //Mbappe -> mbappe
           //mBappe -> mbappe
           string spelare = Console.ReadLine().ToLower();
           
           if (spelare == "mbappe")
           {
               Console.WriteLine("Bra. Du är en expert");
           }
           else
           {
               Console.WriteLine("Fel! Det var Mbappe");
           }
        }
    }
}
