using Raylib_cs;
using System.Numerics;

class DrawPlatform{
    virtual public void Draw() {
    }
}

class LevelOnePlatforms: DrawPlatform{
    override public void Draw() {
        Raylib.DrawRectangle(10, 10, 5,100, Color.GREEN);
        Raylib.DrawRectangle(10, 10, 5,100, Color.GREEN);
    }
}
class LevelTwoPlatforms: DrawPlatform{
        override public void Draw() {
            Raylib.DrawRectangle(10, 10, 5,100, Color.GREEN);
            Raylib.DrawRectangle(10, 10, 5,100, Color.GREEN);
        }
}