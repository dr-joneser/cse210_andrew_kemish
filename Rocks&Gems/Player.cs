using Raylib_cs;
using System.Numerics;

class Player: MovementHorizontal{
    override public void Draw(){
    var PlayerRectangle = new Rectangle(430, 400, 20, 20);
    Raylib.DrawRectangle(400, 450, 20,20, Color.GREEN);
    }



}