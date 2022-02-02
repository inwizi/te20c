using System;

namespace Labb_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
           Console.WriteLine("Program som skriver ut ASCII");

           // Be användaren mata in ett ord
           Console.Write("Ange ett ord: ");
           string ord = Console.ReadLine();


           // Loopa igenom ordet bokstav-för-bokstav
          for (int i = 0; i < ord.Length; i++)
          {
          char bokstav = ord[i];

          int kod = (int)bokstav;

          kod = kod + nyckel;

          char bokstavKrypterad = (char)(kod);


          Console.WriteLine($ "{bokstav} {kod} {bokstavKrypterad}");

          }
         
        }
    }
}
