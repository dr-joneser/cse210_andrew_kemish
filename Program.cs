// Get input from user and convert to int

Console.Write("What is your grade percent? ");
string? numberInText = Console.ReadLine();
int number;
number = Convert.ToInt32(numberInText);

// Determin what letter grade is appropriate and display to terminal
if (number >= 90)
{
    string letterGrade = "A";
    Console.Write($"Your letter grade is: {letterGrade}");
}
else if (number >= 80)
{
    string letterGrade = "B";
    Console.Write($"Your letter grade is: {letterGrade}");
}
else if (number >= 70)
{
    string letterGrade = "C";
    Console.Write($"Your letter grade is: {letterGrade}");
}
else if (number >= 60)
{
    string letterGrade = "D";
    Console.Write($"Your letter grade is: {letterGrade}");
}
else
{
    string letterGrade = "F";
    Console.Write($"Your letter grade is: {letterGrade}");
}

// Print on a new line.
Console.WriteLine(" ");

// Display message if above 70%
if (number >= 70)
{
    Console.Write("Congratulations! You passed the class!");
}
else
{
    Console.Write("Stay focused and you'll get it next time!");
}