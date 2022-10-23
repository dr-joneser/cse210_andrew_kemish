class generateWord{
// List with different words
    public static List<string> WordList = new List<string>();
// EMPTY LIST WHERE THE WORD GOES
    private static List<string>SelectedWord = new List<string>();
    public List<string> Underscorez(List<string> ChosenWord)
    {
        List<string> UnderscoreList = new List<string>();
        foreach(string character in ChosenWord)
        {
            UnderscoreList.Add("_ ");
        }
        return UnderscoreList;
    }
    public void Spaces(List<string> ChosenWord)
    {

        foreach (string character in ChosenWord)
        {
            Console.Write("_ ");
        }
    }


// ADD WORDS TO THE WORD LIST
        void AddWords(){
        WordList.Add("f e n c e");
        WordList.Add("s t r a n g e");
        WordList.Add("e x i s t");
        WordList.Add("a l l e y");
        WordList.Add("a d v e n t u r e");
        WordList.Add("c l a s s e s");
    }
    public generateWord()
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
            }
    }

    public void DisplayGuesses(string guess,List<string> UnderscoreList)
    {
        for (int j = 0; j < AccesibleWord.Count; j++)
{
                    if (guess == SelectedWord[j])
                        UnderscoreList[j] = guess;
                }
                Console.WriteLine(guess);
    }


    
// Generate a list with ____ according to the chosen word
// Pull the users guesses
// Create a loop that will compare the list with the guess and update the underscore list
// 
// If a string from the 'guess' list is in 'Underscores' list update __ to (a-z)

}