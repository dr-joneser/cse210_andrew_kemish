// See https://aka.ms/new-console-template for more information

Console.Write("What is your grade percent? ");
string? numberInText = Console.ReadLine();
int number = int.Parse(numberInText);

if (number >= 90)
{
    string letterGrade = "A";
}
else if (number >= 80)
{
    string letterGrade = "B";
}
else if (number >= 70)
{
    string letterGrade = "C";
}
else if (number >= 60)
{
    string letterGrade = "D";
}
else
{
    string letterGrade = "F";
}

Console.Write($"Your letter grade is: {letterGrade}");

if (number >= 70)
{
    Console.Write("Congratulations! You passed the class!");
}
else
{
    Console.Write("Stay focused and you'll get it next time!");
}