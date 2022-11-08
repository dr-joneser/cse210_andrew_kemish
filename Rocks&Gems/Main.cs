using Raylib_cs;
using System.Numerics;

class MainRocks {
    static class Program
    {
        public static void MainRocks()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 800;
            
            var RectangleSize = 50;
            var Objects = new List<GameObject>();
            var Random = new Random();

            var PlayerRectangle = new Rectangle(ScreenWidth - (RectangleSize * 2), ScreenHeight - (RectangleSize * 2), RectangleSize, RectangleSize);
            var TargetRectangle = new Rectangle(100, 100, RectangleSize, RectangleSize);
            var MovementSpeed = 4;

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Rocks and Gems");
            Raylib.SetTargetFPS(60);
            int score = 0;

            while (!Raylib.WindowShouldClose())
            {
<<<<<<< HEAD
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Move the red square to the blue square with the arrow keys!", 12, 12, 20, Color.BLACK);
                Raylib.DrawText($"Score: {score}");

                var RockGem = Random.Next(2);
                int PositionX = Random.Next(0, ScreenWidth);
                var position = new Vector2 (PositionX , 0);

                switch (RockGem){
                    case 0;
                    var square 
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    PlayerRectangle.x += MovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    PlayerRectangle.x -= MovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                    PlayerRectangle.y -= MovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                    PlayerRectangle.y += MovementSpeed;
                }

                Raylib.DrawRectangleRec(TargetRectangle, Color.BLUE);
                Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

                if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {
                    Raylib.DrawText("You did it!!!!", 12, 34, 20, Color.BLACK);
                }

                Raylib.EndDrawing();
=======
                // INTRO TEXT 
                // Raylib.DrawText("Move the red square to the blue square with the arrow keys!", 12, 12, 20, Color.BLACK);
                Raylib.DrawText($"Score: {score}",12,12,15,Color.BLACK);

                var RockOrGem = Random.Next(2);
                

                int PositionX = Random.Next(0, ScreenWidth);
                var position = new Vector2 (PositionX , 0);

                switch (RockOrGem){
                    // If case is 0 it'll create a Rock
                    case 0:
                    Console.WriteLine("Creating a Rock");
                        var Rock = new GameRock();
                        Rock.Position = position;
                        Rock.Velocity = new Vector2(0,18);
                        Rocks.Add(Rock);
                        break;
                    case 1:
                        var Gem = new GameGem();
                        Gem.Position = position;
                        Gem.Velocity = new Vector2(0,-2);
                        Gems.Add(Gem);
                        break;
                    default:
                        break;
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                // Draw all of the objects in their current location
                foreach (var obj in Rocks) {
                    obj.Draw();
                }
                foreach (var obj in Gems) {
                    obj.Draw();
                }

                Raylib.EndDrawing();

                // Move all of the objects to their next location
                foreach (var obj in Rocks) {
                    obj.MoveVertical();
                }
                foreach (var obj in Gems) {
                    obj.MoveVertical();
                }
>>>>>>> parent of 04418e0 (gem)
            }

            Raylib.CloseWindow();
        }
    }
<<<<<<< HEAD
=======


                // if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                //     PlayerRectangle.x += MovementSpeed;
                // }

                // if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                //     PlayerRectangle.x -= MovementSpeed;
                // }

                // if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                //     PlayerRectangle.y -= MovementSpeed;
                // }

                // if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                //     PlayerRectangle.y += MovementSpeed;
                // }

                // Raylib.DrawRectangleRec(TargetRectangle, Color.BLUE);
                // Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

                // if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {
                //     Raylib.DrawText("You did it!!!!", 12, 34, 20, Color.BLACK);
                // }
>>>>>>> parent of 04418e0 (gem)
}