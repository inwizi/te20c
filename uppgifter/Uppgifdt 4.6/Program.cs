using System;

namespace Uppgifdt_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ut 1,2,3,4,5
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            //Skriv ut 9,8,7,6,5,4,3,2,1
            for (int x = 9; x > 0; x--)
            {
                Console.WriteLine(x);
            }


            //Summera alla siffror 1-10 1+2+3+4+5+6+7+8+9+10
            int summa = 0;
            for (var i = 1; i < 11; i++)
            {
                summa += i;
            }
            Console.WriteLine($"Summa är {summa}");

            string namn = "Mohammad";

            //Skriv ut andra bokstaven
            Console.WriteLine(namn[0]);  //M
            Console.WriteLine(namn[1]);  //O
            Console.WriteLine(namn[3]);  //H
            Console.WriteLine(namn[4]);  //M

            //Skriv ut baklänges
            for (var i = 7; i > -1; i--)
            {
                Console.WriteLine(namn[i]);
            }

        }
    }
}
