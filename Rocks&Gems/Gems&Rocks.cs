using Raylib_cs;
using System.Numerics;

class GameRock: MovementVertical{
    public int Size {get; set; }
    Random rnd = new Random();
    int RandInt = rnd.Next(20,780);
    override public void Draw() {
        Raylib.DrawText("o", 0 , RandInt, 15, color.RED);
    }
}


class GameGem: MovementVertical{
    public int Size {get; set; }
    Random rnd = new Random();
    int RandInt = rnd.Next(20,780);
    override public void Draw() {
        Raylib.DrawText("*", 0 , RandInt, 15, color.RED);
    }
}