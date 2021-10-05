using System;

namespace GissaEttTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Spel - gissa ett tal mellan 1 och 100. ");

            // Spela flera gånger 
            while (true)
            {
                          //Slumpa fram ett tal
            Random tärning = new Random(); 
            int slumptal = tärning.Next(1,101);

            
            //upprepa fråga 
            int räknare = 1;
            while (true)
            {
                //räkna upp antal gissningar = varv
                räknare++;
               
           
            }

            }

   
           
        }
    }
}
