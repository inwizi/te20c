using System;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            Console.ReadLine();
            
            
            Random tärning = new Random();
            int Bruttolön = tärning.Next (10000,45000);

            Console.Write("Ange din bruttolön i kronor (10000 - 45000) ");
            int lön = int.Parse(Console.ReadLine());
            


            if (Bruttolön < 10000  )
            {
                Console.WriteLine("Bruttolön kan inte vara mindre än 10000");              
            }
            else
            {
                Console.WriteLine("Bruttolön kan inte vara större än 45000");
            }

           

           

            
         
        }
    }
}
