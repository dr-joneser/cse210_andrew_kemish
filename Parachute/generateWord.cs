public class generateWord{
    // List with different words
    public List<string> words = new List<string>();
    // List with the randomly chosen word split by letters
    public List<string> SplitWord = new List<string>();
    public List<string> Spaces = new List<string>();

    void AddWords(){
        // Add a series of words to the words list
        generateWord myObj = new generateWord();
        myObj.words.Add("f e n c e");
        myObj.words.Add("s t r a n g e");
        myObj.words.Add("e x i s t");
        myObj.words.Add("a l l e y");
        myObj.words.Add("a d v e n t u r e");
        myObj.words.Add("c l a s s e s");}
    // THE CLASS WILL CHOOSE THE WORD AND SPLIT IT
    void PickWord(string [] args){
        generateWord myObj = new generateWord(); 
        // Pick one of the words from the list at random
        Random rnd = new Random();
        int randIndex = rnd.Next(myObj.words.Count);
        string ChosenWord = myObj.words[randIndex];
        // Split the chosen word into letters and add them to the SplitWord list
        Char[] myChars = {' '};
        string[] SeparatedWord = ChosenWord.Split(myChars);
        foreach (string x in SeparatedWord)
        {
        myObj.SplitWord.Add(x);
        }
    }
    // Generate  a list that contains only __

    static void AddSpaces(List<string> Word){
        generateWord myObj = new generateWord();
        List<string> SeparatedWord = myObj.SplitWord;
        foreach (string x in Word ){
            myObj.Spaces.Add("_ ");
        
        }
    }
}