public class Score {

    // If the user guessed correctly, then return true. 
    // Comparing old card to new card and then checking the user input.
    // Parameters: oldCardNumber is the previous card as a integer.
    // newCardNumber is the newly generated card as an integer.
    // userGuess is a bool, if the user said high then true, if they said low then false.
    // Return: A bool, if guessed correct then true, else false.
    public bool CheckIfCorrect (int oldCardNumber, int newCardNumber, bool userGuess) {
        if (oldCardNumber > newCardNumber && userGuess == false) {
            return true;
        }
        else if (newCardNumber > oldCardNumber && userGuess == true){
            return true;
        }
        else {
            return false;
        }
    }

    // If the user guessed correctly, then add 100 points to current score.
    // If the user guessed incorrect, then subtract 75 points from current score.
    // Parameters: 'correct' is a bool that will be true if they guessed correctly.
    // 'score' is the current score for the game.
    public int NewScore (bool correct, int score) {
        if (correct == true) {
            score = (score + 100);
        }
        else {
            score = (score - 75);
        }
        return score;
    }

    // Display score to player.
    public static void DisplayScore(int score) {
        Console.WriteLine($"Your Score is: {score}");
    }
    // Display New score to player
    public static void NewScore(int score){
        Console.WriteLine($"Your Score is: {score}");

    }

}