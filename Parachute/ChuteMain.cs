class program{
static void Main(){
    int fails = 0;
    bool NoChute = false;
    // PRINT STATEMENT
    Console.WriteLine("A random word will be generated. You will then be asked to guess a letter.");
    Console.WriteLine("If the letter is in the word it will show up on the screen. If not a line from the parachute will be deleted.");
    Console.WriteLine("After 8 failed guesses the parachute will be erased and the game will be over.");
    draw.AddLines(fails);
    generateWord.AddWords();
    generateWord.PickWord();
// WHILE LOOP
    while (fails < 8 && NoChute == false){
    draw.doodle();


    fails = 9;
    }
}
}

// Print statement
// LOOP***
// draw parachute
// Choose word
// display spaces
// Ask for input
// return true or false
// delete line or replace letter
// LOOP***