class generateWord{
// List with different words
    private  List<string> AddWords()
    {
        List<string> words= new List<string>();
        words.Add("f e n c e");
        words.Add("s t r a n g e");
        words.Add("e x i s t");
        words.Add("a l l e y");
        words.Add("a d v e n t u r e");
        words.Add("c l a s s e s");
        return words;
    }
// LIST WITH THE CHOSEN WORD
    private List<string> ChooseWord()
    {
        List<string> chosenWord = new List<string>();
        List<string> wordList = AddWords();
    // Choose a word at random
        generateWord myObj = new generateWord();
        Random rnd = new Random();
        int randIndex = rnd.Next(wordList.Count);
        string ChosenWord = wordList[randIndex];
    // Split the word into individual letters and add them to a new list
        Char[] myChars = {' '};
        string[] SeparatedWord = ChosenWord.Split(myChars);
        foreach (string x in SeparatedWord)
        {
        chosenWord.Add(x);
        }
        return chosenWord;
    }
// LIST WITH ___
    private List<string> Underscores()
    {
        List<string> Underscores = new List<string>();
        List<string> chosenWord = ChooseWord();

        foreach (string x in chosenWord ){
            Underscores.Add("_ ");
        }
        return Underscores;
    }
    public List<string> DisplayGuesses(string guess){
        List<string> chosenWord = ChooseWord();
        List<string> emptyWord = Underscores();
        int i =0;
        foreach (string character in chosenWord) {
            if (character == guess)
            {
                emptyWord.Insert(i,guess);
            }
                i += 1;
            }
            return emptyWord;
    }
    public void Display(string guess){
        int i=0;
        List<string> emptyList = new List<string>();
        List<string> chosenWord = ChooseWord();
         foreach (string character in chosenWord) {
            if (character == guess)
            {
                Console.WriteLine(guess);
                emptyList.Insert(i,guess);
            }
            else
            {
                Console.WriteLine("_ ");
            emptyList.Insert(i, "_ ");
            }
            i += 1;}
    }
}