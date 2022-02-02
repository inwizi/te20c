using System;
using Raylib_cs;

namespace Dodgers
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
            //Game State Variabler
            int poäng = 0;
            int liv = 3;
            float tid = 0;
    
            Random generator = new Random();
            Rectangle mynt = new Rectangle(400, 0, 50, 50);
            Rectangle spelare = new Rectangle(100, fönsterH - 50, 100, 10);
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                mynt.y += 1;
                if (mynt.y > fönsterH)
                {
                    mynt.y = -100;
                    mynt.x = generator.Next(0, fönsterB);
                }

                //Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    if (spelare.x > 3)
                    {
                        spelare.x -= 3;
                    }
                    spelare.x -= 4;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    if (spelare.x < fönsterB - 100)
                    {
                        spelare.x += 0;
                    }
                    spelare.x += 4;
                }

                //Om spelaren träffar ett mynt 
                if (Raylib.CheckCollisionRecs(spelare, mynt))
                {
                    mynt.y = 0;
                    mynt.x = generator.Next(0, fönsterB);
                    poäng += 5;
                }
                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                Raylib.DrawRectangleRec(mynt, Color.GOLD);
                Raylib.DrawRectangleRec(spelare, Color.WHITE);
                Raylib.DrawText($"Poäng:{poäng} Liv:{liv}", 10, 10, 20, Color.YELLOW );

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}