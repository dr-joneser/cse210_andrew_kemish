using Raylib_cs;
using System.Numerics;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {
            // CONSTANTS
            var ScreenWidth = 480;
            var ScreenHeight = 800;
            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);
            int level = 1;
            bool GameOver = false;

            // Platform List for level one and two
            var LevelOnelist = new List<Rectangle>();
            var LevelTwoList = new List<Rectangle>();
            
            // Add platforms to the list. Platforms will have a top and a bottom half
            var TopHalves = new LevelOneTopPlatforms();
            TopHalves.CreateTopList();
            foreach (var obj in TopHalves.TopHalfList){
                LevelOnelist.Add(obj);
            }
            var BottomHalves = new LevelOneBottomPlatforms();
            BottomHalves.CreateBottomList();
            foreach (var obj in BottomHalves.BottomHalfList){
                LevelOnelist.Add(obj);
            }
            // Game execution
            while (!Raylib.WindowShouldClose())
            {
                // Draw level one platforms
                if (level == 1){
                    foreach(var obj in LevelOnelist ){
                        // obj.Draw();
                        Raylib.DrawRectangle((int)obj.x,(int)obj.y,(int)obj.width,(int)obj.height,Color.GREEN);
                    }
                }



                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}

