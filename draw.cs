public class draw{
   public static List <string> chute = new List<string>();  
    public static List <string> dude = new List<string>();
   public static void Main(){    
     chute.Add(" ___");
     chute.Add("/");
     chute.Add("___");
     chute.Add(@"\ ");
     chute.Add(@"\   ");
     chute.Add("/");
     chute.Add(@" \ ");
     chute.Add("/");
     dude.Add("  o");
     dude.Add(@" /|\");
     dude.Add(@" / \");
   }
    public static void doodle(){
        Console.WriteLine($"{chute[0]}");
        Console.WriteLine($"{chute[1]}{chute[2]}{chute[3]}");
        Console.WriteLine($"{chute[4]}{chute[5]}");
        Console.WriteLine($"{chute[6]}{chute[7]}");
        foreach(var limb in dude)
        {Console.WriteLine(limb);}
       }
    
    public void delete(bool guess, int fails){
        if (guess == false){
            int misses = fails -1;
            chute.RemoveAt(misses);
            chute.Insert(misses,"");
        }

    }
}