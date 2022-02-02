using System;
using Raylib_cs;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            // TODO: Infoga variabler och objekt här
            Random generator = new Random();


            //Array [] för många snöflingor 
            Rectangle[] flingor = new Rectangle[100];

            //Loopa igenom Array och fyll med snöflingor
            for (int i = 0; i < flingor.Length; i++)
            {
               
                flingor[i] = new Rectangle(0, 0, 10, 10);
                flingor[i].x = generator.Next(0, fönsterB);
  
            }


           
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                  for (int i = 0; i < flingor.Length; i++)
            {
               flingor[i].y += 1;
                
            }
             /*   snö.y += 1;
                if (snö.y > fönsterH)
                {
                    snö.y = 0;
                    snö.x = generator.Next(0, fönsterB);
                }
                */
                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
               Raylib.ClearBackground(Color.DARKBLUE);

               for (int i = 0; i < flingor.Length; i++)
            {
               
                Raylib.DrawRectangleRec(flingor[i], Color.WHITE);
            }


                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}