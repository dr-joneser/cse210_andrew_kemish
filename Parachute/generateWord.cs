class Word{
    private List<string> words = new List<string>();
    private List<string> SplitWord = new List<string>();
    static void Main(String [] args){
        Word myObj = new Word();
        myObj.words.Add("f e n c e");
        myObj.words.Add("s t r a n g e");
        myObj.words.Add("e x i s t");
        myObj.words.Add("a l l e y");
        myObj.words.Add("a d v e n t u r e");
        myObj.words.Add("c l a s s e s");
        Random rnd = new Random();
        int randIndex = rnd.Next(myObj.words.Count);
        string ChosenWord = myObj.words[randIndex];
        Console.WriteLine($"The word is {ChosenWord}");
        Char[] myChars = {' '};
        string[] SeparatedWord = ChosenWord.Split(myChars);
        foreach (string x in SeparatedWord)
        {
        myObj.SplitWord.Add(x);
        }
        }
}