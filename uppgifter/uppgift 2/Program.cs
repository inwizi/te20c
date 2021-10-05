using System;

namespace uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HUr gammal är du?");
            string ålder = Console.ReadLine();

            Console.WriteLine($"Du är{ålder} gammal");

            int ålderTal = int.Parse(ålder);

            Console.WriteLine($"Du har {20 -ålderTal} år kvar tills du får gå på System");

            Console.WriteLine("Hur mycket väger du?");
            float vikt = float.Parse(Console.ReadLine());

            Console.WriteLine($"Din vikt blir {vikt * 2.2} LBS");
        }
    }
}
