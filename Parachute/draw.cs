public class draw{
    //Create an empty list for the parachute lines
   public static List <string> chute = new List<string>();  
//Create an empty list for the dude's limbs
    public static List <string> dude = new List<string>();
    // Add the lines/limbs for the parachute/dude
   public static void AddLines(int fails){    
     chute.Add(" ___");
     chute.Add("/");
     chute.Add("___");
     chute.Add(@"\ ");
     chute.Add(@"\   ");
     chute.Add("/");
     chute.Add(@" \ ");
     chute.Add("/");
     if (fails == 8){
        dude.Add("  x");}
     else{
        dude.Add("  o");}
     dude.Add(@" /|\");
     dude.Add(@" / \");
   }
//    The class will print out the parachute and the dude
    public static void doodle(){
        Console.WriteLine($"\n{chute[0]}");
        Console.WriteLine($"{chute[1]}{chute[2]}{chute[3]}");
        Console.WriteLine($"{chute[4]}{chute[5]}");
        Console.WriteLine($"{chute[6]}{chute[7]}");
        foreach(var limb in dude)
        {Console.WriteLine(limb);}
       }
    // If the guess is false this class will delete the parachute
    public void deleteChute(bool compare, int fails){
        if (compare == false){
            int misses = 9 - fails;
            chute.RemoveAt(fails - 1);
            chute.Insert(fails -1,"");
        }

    }
    // Once the player has hit 8 fails the head becomes an x
    public void switchHead(int fails){
        if (fails == 8){
            dude.RemoveAt(0);
            dude.Insert(0,"x");
        } 
    }

}