

class PlayerScore: Position{
    public int score = new int();

    //SCORE POSITION
    xPos = 12;
    yPos = 12;

    // DISPLAY SCORE
    public static void DrawScore(int score) {
        Raylib.DrawText("text", xPos, yPos, 10, GRAY);
    }

}