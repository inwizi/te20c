using System;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in di e-post");
            string epost = Console.ReadLine();
            
            //Kolla att texten innehåller @
            if (epost.Contains("@"))
            {
                Console.WriteLine("Det verkar som du skriver in en korrekt epostadress");
            }

            Console.WriteLine("Mata in ett mattetal");
            string mattetal = Console.ReadLine();


            //Berätta om : + eller - eller / eller *
            bool flagga = false;
            if (mattetal.Contains("+"))
            {
                Console.WriteLine("Du använder operator +");
                flagga = true;
            }

            if (mattetal.Contains("-"))
            {
                Console.WriteLine("Du använder en operator -");
                flagga = true;
            }

            if (mattetal.Contains("*"))
            {
                Console.WriteLine("Du använder en operator *");
                flagga = true;
            }

            if (mattetal.Contains("/"))
            {
                Console.WriteLine("Du använder en operator /");
                flagga = true;
            }

            if (flagga)
            {
                Console.WriteLine("Du använde inte *, -, +, /");
            }


            
        }
    }
}
