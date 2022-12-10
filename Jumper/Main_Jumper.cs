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

            // Platform List for levels one and two
            var LevelOneList = new List<Rectangle>();
            var LevelTwoList = new List<Rectangle>();
            
            // Add platforms to the list. Platforms will have a top and a bottom half
            var TopHalves = new LevelOneTopPlatforms();
            TopHalves.CreateTopList();
            foreach (var obj in TopHalves.TopHalfList){
                LevelOneList.Add(obj);
            }
            
            var BottomHalves = new LevelOneBottomPlatforms();
            BottomHalves.CreateBottomList();
            foreach (var obj in BottomHalves.BottomHalfList){
                LevelOneList.Add(obj);
            }
            // Define the Players Starting position
            var PlayerPosition = new Vector2(240,700);
            bool OnPlatform = true;
            Vector2 Velocity = new Vector2(0,0);
            // Game execution
            while (!Raylib.WindowShouldClose())
            {
                // Draw all items in the level one list using a foreach loop
                if (level == 1)
                {
                    foreach(var obj in LevelOneList ){
                        // obj.Draw();
                        Raylib.DrawRectangle((int)obj.x,(int)obj.y,(int)obj.width,(int)obj.height,Color.GREEN);
                    }
                }

                // Create the player
                var player = new Player();
                player.Position = PlayerPosition;
                var PlayerRectangle = new Rectangle((int)PlayerPosition.X,(int)PlayerPosition.Y, 15,15);
                player.Draw();
                // Move the player left-right
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    PlayerPosition.X +=4;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    PlayerPosition.X -=4;
                }


                // Check to see if the player is on a platform
                foreach (var obj in LevelOneList) {
                    if (Raylib.CheckCollisionRecs(obj, PlayerRectangle))
                    {
                        OnPlatform = true;
                        break;
                    }
                    else
                    {
                        OnPlatform = false;
                    }
                    }
                Vector2 gravity = player.Gravity(OnPlatform, PlayerPosition);
                PlayerPosition = gravity;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
        }
    }
}


