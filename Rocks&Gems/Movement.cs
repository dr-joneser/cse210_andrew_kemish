using Raylib_cs;
using System.Numerics;


abstract class MovementHorizontal{
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);

    virtual public void Draw(){
        // Base game objects do not have anything to draw
    }
    // X-VALUE POSITION OF PLAYER IS CHANGED WHEN LEFT OR RIGHT ARROW KEYS ARE PRESSED
    public void MovePlayer()
    {
        Vector2 NewPosition = Position;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    NewPosition.X += 2;
                    Position = NewPosition;
                }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    NewPosition.X -= 2;
                    Position = NewPosition;
                }
        else{
            Position = NewPosition;
        }
    }
}

Random Rnd = new Random();
public int RandInt = Rnd.Next(20,780);
abstract class MovementVertical{
    
    public Vector2 Position = new Vector2(RandInt, 0);
    public Vector2 Velocity = new Vector2(0, 18);
    // Y-VALUE POSITION OF ROCKS AND GEMS ARE INCREASING AT A CONSTANT RATE (GRAVITY)
    virtual public void Draw() {
        // Base game objects do not have anything to draw
    }
    public void MoveVertical(){
        Vector2 NewPosition = Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;
    }
   
}