class Para_Input {
public string? letterGuess = "";

    public string AskUser() {
        Console.Write("Higher or Lower? [h/l] ");
        letterGuess = Console.ReadLine();
        if (letterGuess is null) {
            letterGuess = "";
        }
        return letterGuess;
    }
    
    public bool CompareToWord(string guess, List<string> word) {
        if (word.Contains($"{guess}")) {
            return true;
        }
        else return false;
    }
    
    public void ReplaceList(List<string> word, bool compare, string guess){
        if (compare) {
            foreach (string character in word) {
                

            }
        }

    }

    
}

