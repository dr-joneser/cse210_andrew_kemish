class Word{
    private List<string> words = new List<string>();
    private List<string> SplitWord = new List<string>();
    static void Main(String [] args){
        Word myObj = new Word();
        myObj.words.Add("fence");
        myObj.words.Add("strange");
        myObj.words.Add("exist");
        myObj.words.Add("alley");
        myObj.words.Add("adventure");
        myObj.words.Add("classes");
        Random rnd = new Random();
        int randIndex = rnd.Next(myObj.words.Count);
        string ChosenWord = myObj.words[randIndex];
        Console.WriteLine($"The word is {ChosenWord}");
        ChosenWord.Split();
        Char[] myChars = {};
        string[] SeparatedWord = ChosenWord.Split(myChars);
        foreach (string x in SeparatedWord){
        Console.WriteLine($",{x}");
        }
        }
}