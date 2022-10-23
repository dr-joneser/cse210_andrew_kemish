class Para_Input {
public string? letterGuess = "";


    // Getting the letter from the user and making sure that the input is not null.
    public string AskUser() {
        Console.WriteLine("");
        Console.Write("Guess a letter [a-z]:");
        letterGuess = Console.ReadLine();
        if (letterGuess is null) {
            letterGuess = "";
        }
        return letterGuess;
    }
    

    // Checking to see if the word contains that letter that the user guessed, and returns true if correct.
    public bool CompareToWord(string guess, List<string> word) {
        if (word.Contains($"{guess}")) {
            return true;
        }
        else return false;
    }
    

    // Replacing the empty list of '_' with the letter that the user guessed if they were correct. 
    public void ReplaceList(List<string> word, string guess, List<string> emptyWord){
        if (CompareToWord(guess, word)) {
            int i = 0;
            foreach (string character in word) {
                if (character == guess) {
                    emptyWord.RemoveAt(i);
                    emptyWord.Insert(i, guess);
                
                }
                i += 1;
                }
            }
        foreach( string character in emptyWord)
        {
        Console.Write(character);
        }
        }
    }
