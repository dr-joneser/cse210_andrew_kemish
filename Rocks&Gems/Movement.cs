using Raylib_cs;
using System.Numerics;


abstract class MovementHorizontal{
    public Vector2 Position = new Vector2(0, 0);
    public Vector2 Velocity {get; set; } = new Vector2(0, 0);

    virtual public void Draw(){
        // Base game objects do not have anything to draw
    }
    // X-VALUE POSITION OF PLAYER IS CHANGED WHEN LEFT OR RIGHT ARROW KEYS ARE PRESSED
}

abstract class MovementVertical{
    public Vector2 Position {get; set; } = new Vector2(0, 0);
    public Vector2 Velocity {get; set; } = new Vector2(0, 0);
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