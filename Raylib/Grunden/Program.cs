using System;
using Raylib_cs;

namespace Grunden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Raylib");

            //Starta förnster 
            Raylib.InitWindow(800, 600, "Ett Raylib Fönster");

            //Ställ in FPS
            Raylib.SetTargetFPS(60);

            //Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
              //Börja rita
              Raylib.BeginDrawing();


               
              //Tömma ritytan
              Raylib.ClearBackground(Color.DARKBLUE);


              //Rita end fyrkant
              Raylib.DrawRectangle(100, 100, 200, 100, Color.GOLD);


              //Sluta rita
              Raylib.EndDrawing();
            }

        }
    }
}
