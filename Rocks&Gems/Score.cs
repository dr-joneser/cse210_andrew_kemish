using Raylib_cs;
using System.Numerics;

class PlayerScore: Position{
    public int score = new int();

    //SCORE POSITION

    // DISPLAY SCORE
    public static void DrawScore(int score) {
        int xPos = 12;
        int yPos = 12;
        Raylib.DrawText("text", xPos, yPos, 10, GRAY);
    }

}