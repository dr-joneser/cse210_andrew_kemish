using Raylib_cs;
using System.Numerics;

class Player: MovePlayer{
    public void Draw(){
        var PlayerRectangle = new Rectangle(430, 400, 20, 20);
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, 15,15, Color.BLUE);
    }
}

class MovePlayer{
    
    public Vector2 Position {get; set; } = new Vector2(0, 0);
    public Vector2 Gravity(bool OnPlatform, Vector2 PlayerPosition){
    var player = new Player();
    Vector2 possition = PlayerPosition;
        if (OnPlatform == true)
        {
            Vector2 Landing = possition;
            Landing.X = possition.X;
            Landing.Y += 0;
            possition = Landing;
        }
        if(TouchBottom == true)
        {
            Vector2 Falling = possition;
            Falling.X = possition.X;
            Falling.Y += -1;
            possition = Falling;
        }

        else
        {
            Vector2 Falling = possition;
            Falling.X = possition.X;
            Falling.Y += -1;
            possition = Falling;
        }
        return possition;
    }
}




// Player can move in 3 directions
// 1. Down - Caused by Gravity
// Activated by being airborne or touching the bottom of a platform
// 2. Up - Player presses up key and they jump
// After a while they stop jumping
// 3. Stationary - Cause by landing on a platform
// They stay there indefinitely