class program{
static void Main(){
    int fails = 0;
    bool Win = false;
    draw.AddLines(fails);
    string guess = "g";
    // PRINT STATEMENT
    Console.WriteLine("A random word will be generated. You will then be asked to guess a letter.");
    Console.WriteLine("If the letter is in the word it will show up on the screen. If not a line from the parachute will be deleted.");
    Console.WriteLine("After 8 failed guesses the parachute will be erased and the game will be over.");
    generateWord myObj = new generateWord();
    while (fails < 8 && Win == false){
    // DRAW THE DUDE/PARACHUTE
    draw.doodle();
    // DISPLAY THE WORD
    myObj.DisplayGuesses(guess);


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