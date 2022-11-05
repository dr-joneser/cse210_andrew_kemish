using Raylib_cs;
using System.Numerics;


class GameObject {
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);

    virtual public void Draw() {
        // Base game objects do not have anything to draw
    }

    public void Move() {
        Vector2 NewPosition = Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;
    }
}

class ColoredObject: GameObject {
    public Color Color { get; set; }

    public ColoredObject(Color color) {
        Color = color;
    }
}

class GameSquare: ColoredObject {
    public int Size { get; set; }

    public GameSquare(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }
}

class GameCircle: ColoredObject {

    public int Radius { get; set; }

    public GameCircle(Color color, int radius): base(color) {
        Radius = radius;
    }

    override public void Draw() {
        Raylib.DrawCircle((int)Position.X, (int)Position.Y, Radius, Color);
    }
}

class GameText: ColoredObject {
    public int FontSize { get; set; }

    public GameText(Color color, int fontSize): base(color) {
        FontSize = fontSize;

    }

    override public void Draw() {
        Raylib.DrawText("TEXT", (int) Position.X, (int)Position.Y, FontSize, Color);
    }
}


// MAIN PROGRAM
using Raylib_cs;
using System.Numerics;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var Objects = new List<GameObject>();
            var Random = new Random();

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                // Add a new random object to the screen every iteration of our game loop
                var whichType = Random.Next(3);

                // Generate a random velocity for this object
                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);

                // Each object will start about the center of the screen
                var position = new Vector2(ScreenWidth / 2, ScreenHeight / 2);

                switch (whichType) {
                    case 0:
                        Console.WriteLine("Creating a square");
                        var square = new GameSquare(Color.YELLOW, 50);
                        square.Position = position;
                        square.Velocity = new Vector2(randomX, randomY);
                        // To the list add a variable
                        Objects.Add(square);                        
                        break;
                        bootyholebootyholeHEHE
                    case 1:
                        Console.WriteLine("Creating a circle");
                        // declare variable by calling class and adding arguments
                        var circle = new GameCircle(Color.BLUE, 50);
                        // 
                        circle.Position = position;
                        circle.Velocity = new Vector2(randomX, randomY);

                        Objects.Add(circle);
                        break;
                    case 2:
                        Console.WriteLine("Creating some text");
                        var text = new GameText(Color.BLACK, 30);
                        text.Position = position;
                        text.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(text);
                        break;
                    default:
                        break;
                }


                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                // Draw all of the objects in their current location
                foreach (var obj in Objects) {
                    obj.Draw();
                }

                Raylib.EndDrawing();

                // Move all of the objects to their next location
                foreach (var obj in Objects) {
                    obj.Move();
                }
            }

            Raylib.CloseWindow();
        }
    }
}


