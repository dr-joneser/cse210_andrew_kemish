using Raylib_cs;
using System.Numerics;

class Player: MovementHorizontal{
    override public void Draw(){
        var PlayerRectangle = new Rectangle((int)Position.X, (int)Position.Y, 20, 20);
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, 15, 15, Color.GREEN);
    }



}