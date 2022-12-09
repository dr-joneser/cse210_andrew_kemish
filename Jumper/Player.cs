using Raylib_cs;
using System.Numerics;

class Player{
    public Vector2 Position {get; set; } = new Vector2(0, 0);
    public void Draw(){
        var PlayerRectangle = new Rectangle(430, 400, 20, 20);
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, 15,15, Color.BLUE);
    }
}

class MovePlayer: Player{
    
    public Vector2 Gravity(bool OnPlatform, int playerX){
    var player = new Player();
    Vector2 possition = player.Position;
        if (OnPlatform == true)
        {
            int i = 0;
            Vector2 Landing = possition;
            Landing.X = playerX;
            Landing.Y += i;
            possition = Landing;
        }
        else
        {
            int z = 3;
            Vector2 Falling = possition;
            Falling.X = playerX;
            Falling.Y += z;
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