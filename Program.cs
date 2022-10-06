class Program {
    static void Main(string[] args) {
        Input.Welcome();
        
        // Call card class to display current card.
        Input UserInput = new Input();
        UserInput.AskUser();
        // Call card class and display next card.
        Score.CheckIfCorrect(oldCardNumber,newCardNumber,UserInput);

        
    } 
}