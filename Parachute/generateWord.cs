class Word{
    // List with different words
    private List<string> words = new List<string>();
    // List with the randomly chosen word split by letters
    private List<string> SplitWord = new List<string>();

    static void Main(String [] args){
        // Add a series of words to the words list
        Word myObj = new Word();
        myObj.words.Add("f e n c e");
        myObj.words.Add("s t r a n g e");
        myObj.words.Add("e x i s t");
        myObj.words.Add("a l l e y");
        myObj.words.Add("a d v e n t u r e");
        myObj.words.Add("c l a s s e s");
        // Pick one of the words from the list at random
        Random rnd = new Random();
        int randIndex = rnd.Next(myObj.words.Count);
        string ChosenWord = myObj.words[randIndex];
        // Split the chosen word into letters and add them into the list
        Char[] myChars = {' '};
        string[] SeparatedWord = ChosenWord.Split(myChars);
        foreach (string x in SeparatedWord)
        {
        myObj.SplitWord.Add(x);
        }
        }
}