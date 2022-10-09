class Program {
    static void Main(string[] args) {
        Input.Welcome();
        int score = 300;
        string keepPlaying = "";
        Card1 CurrentCardObj = new Card1();


            // Call card class to display current card.
        int currentCard = CurrentCardObj.Generate(0);

        // Loop gameplay until the user ends or score goes below zero.
        while (keepPlaying != "n" && score > 0) {
            Card1.DisplayCurrentCard(currentCard);

            // See if user guesses 'h' or 'l'.
            Input UserInput = new Input();
            bool answer = UserInput.AskUser();
            
            // Call card class and display next card.
            int newCard = CurrentCardObj.Generate(currentCard);
            Card1.ReplaceOldWithNew(currentCard,newCard);

            // See if the player guessed right, add or subtract the correct amount of points.
            // Then display the score to the user.
            Score RightorWrong = new Score();
            bool correct = RightorWrong.CheckIfCorrect(currentCard,newCard,answer);
            Score CurrentScore = new Score();

            int newScor = CurrentScore.NewScore(correct, score);
            score = newScor;
            currentCard = newCard;

            Score.DisplayScore(score);

            // See if user wants to continue and assign to variable that is in the while loop.
            keepPlaying = UserInput.Continue();
            Console.WriteLine("");
            if (score <= 0) {
                Console.WriteLine("Game Over");
            }
        }
        
    } 
}
