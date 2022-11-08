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
            }

            Raylib.CloseWindow();
        }
    }
}