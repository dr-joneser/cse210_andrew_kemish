class Gems: MovementVertical{
    // It will generate rocks and gems across the screen
    Random rnd = new Random();
    int RandInt = rnd.Next(20,780);
    bool create = true;
// While loop to keep creating gems/Rocks
    static void generate(){
    int i = 0;
    while (i > 5)
    {
        string gem = Raylib.DrawText("*", 0 , RandInt, 15, color.RED);
        string Rock = Raylib.DrawText("o",0,RandInt,15,color.BLACK);
        i+= 1;
    }
    }
}