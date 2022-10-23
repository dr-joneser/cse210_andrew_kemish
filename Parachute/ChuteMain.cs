class proram{
static void Main(){
    // SET THE CONDITIONS FOR THE LOOP TO RUN
    int fails = 0;
    bool Win = false;
    string guess = "";
// OBJECTS
    generateWord myObjWord = new generateWord();
    Para_Input myObjInput = new Para_Input();
    draw myObjDraw = new draw();
    List<string> word = myObjWord.AccesibleWord;
    // DRAW THE DUDE/PARACHUTE
    draw.AddLines(fails);


    // PRINT STATEMENT
    Console.WriteLine("A random word will be generated. You will then be asked to guess a letter.");
    Console.WriteLine("If the letter is in the word it will show up on the screen. If not a line from the parachute will be deleted.");
    Console.WriteLine("After 8 failed guesses the parachute will be erased and the game will be over.");
    // DISPLAY WORD AS ___
    myObjWord.DisplayGuesses(guess);

// WHILE LOOP
    while (fails < 8 && Win == false){
    // DRAW THE DUDE/PARACHUTE
    draw.doodle();
    // ASK FOR INPUT
    guess = myObjInput.AskUser();
    // DISPLAY GUESS
    myObjWord.DisplayGuesses(guess);
    // CHECK TO SEE IF LETTER IS IN WORD
    bool Comparison= myObjInput.CompareToWord(guess, word);
    // ADD +1 FAIL FOR EVERY WRONG GUESS
    if (Comparison== false)
    {
        fails +=1;
    }
    // DELETE A LINE FOR EVERY WRONG GUESS
    myObjDraw.deleteChute(Comparison, fails);

    fails = 9; 
    }
}
}

// Print statement
// Choose word
// LOOP***
// draw parachute
// display spaces
// Ask for input
// return true or false
// delete line or replace letter
// LOOP***