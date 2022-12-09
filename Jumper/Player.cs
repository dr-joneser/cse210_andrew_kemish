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
            // int i = 0;
            Vector2 Landing = possition;
            Landing.X = possition.X;
            Landing.Y += 0;
            possition = Landing;
        }
        else
        {
            // int z = 3;
            Vector2 Falling = possition;
            Falling.X = possition.X;
            Falling.Y += -3;
            possition = Falling;
        }
        return possition;
    }
}


// Player's position is modified by 
// 1. Gravity - Causing it to fall down
// Activated by being airborne or touching bottom of platform
// 2. Jump - Causing him to rise
// After a while they stop jumping
// 3. Platform - Causing them to stick
// They stay there indefinitely