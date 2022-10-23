class generateWordd{
// List with different words
    public List<string> WordList = new List<string>();
// EMPTY LIST WHERE THE WORD GOES
    private List<string>SelectedWord = new List<string>();
    public List <string> Underscores = new List<string>();
// ADD WORDS TO THE WORD LIST
        void AddWords(){
        WordList.Add("f e n c e");
        WordList.Add("s t r a n g e");
        WordList.Add("e x i s t");
        WordList.Add("a l l e y");
        WordList.Add("a d v e n t u r e");
        WordList.Add("c l a s s e s");
    }


    // void includeWords(){
    // WordList.Add("f e n c e");
    // WordList.Add("s t r a n g e");
    // WordList.Add("e x i s t");
    // WordList.Add("a l l e y");
    // WordList.Add("a d v e n t u r e");
    // WordList.Add("c l a s s e s");}
    public generateWordd()
    {
        AccesibleWord = SelectedWord;
    }
// GETTER AND SETTER
    public List<string> AccesibleWord
    {
        get { return SelectedWord; }
        set { 
            AddWords();
            List<string> Words = WordList;
        // Choose a word at random
            Random rnd = new Random();
            int randIndex = rnd.Next(Words.Count);
            string ChosenWord = Words[randIndex];

        // Split the word into individual letters and add them to a new list
            Char[] myChars = {' '};
            string[] SeparatedWord = ChosenWord.Split(myChars);
            foreach (string x in SeparatedWord)
        {
                SelectedWord.Add(x);
        }
            // SelectedWord = value; 
            }
    }

// LIST WITH ___
    void AddUnderscore()
    {
        foreach (string x in AccesibleWord)
        {
            Underscores.Add("_ ");
        }
    }
    
    public void DisplayGuesses(string guess){
        int i=0;
        List<string> emptyList = Underscores;
        List<string> chosenWord = SelectedWord;
         foreach (string character in chosenWord) {
            if (character == guess)
            {
                Console.WriteLine(guess);
                emptyList.RemoveAt(i);
                emptyList.Insert(i,guess);
            }
            i += 1;}
    }
}