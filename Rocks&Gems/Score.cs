

class PlayerScore: Position{
    public int score = new int();

    //SCORE POSITION
    int xPos = 12;
   int yPos = 12;

    // DISPLAY SCORE
    public static void DrawScore(int score) {
        Raylib.DrawText("text", xPos, yPos, 10, GRAY);
    }

}