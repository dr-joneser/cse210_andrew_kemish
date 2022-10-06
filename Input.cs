public class Input {

    string? userAnswer = "";
    string? keepPlaying = "";

    // Ask User for input and if they do not input a "h" or "l" then try to get input again.
    public void AskUser() {
        while (userAnswer != "h" || userAnswer != "l") {
            Console.Write("Higher or Lower? [h/l] ");
            userAnswer = Console.ReadLine();
            if (userAnswer != "h" || userAnswer != "l") {
                Console.WriteLine("Sorry, that is an invalid input. Try Again.");
                Console.WriteLine("");
            }
        }
    }

    // Display welcome message to the player.
    public static void Welcome() {
        Console.WriteLine("Welcome to the High/Low game!");
        Console.WriteLine("You will be given a deck of cards and you must guess if the next card will");
        Console.WriteLine("be higher or lower than the current card. Guessing correctly will earn you");
        Console.WriteLine("100 points, while guessing incorrectly will make you lose 75 points. You start");
        Console.WriteLine("with 300 points and if your score drops below zero then you lose the game.");
        Console.WriteLine("Good Luck!");
        Console.WriteLine("");
    }
    
    // Ask if the user would like to keep playing and store input in the string 'keepPlaying'
    public void Continue() {
        Console.Write("Play again? [y/n] ");
        keepPlaying = Console.ReadLine();
        while (userAnswer != "y" || userAnswer != "n") {
            Console.WriteLine("Sorry, that is an invalid input. Try Again.");
            Console.WriteLine("");
            Continue();
        }
    }

}