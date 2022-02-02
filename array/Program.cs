using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Använda en array");

            //Skapa en array för 3 öar
            string[] öar = new string[3];

            //Första platsen (0)
            öar[0] = "Syros";
            öar[0] = "Naxos";
            öar[0] = "kreta";

            //Byt ut innehållet 
            öar[0] = "Amorgos";

            //Skriv ut innehållet
            Console.WriteLine(öar[0]);
            Console.WriteLine($"Två andra öar är{öar[0]}");
        }
    }
}
