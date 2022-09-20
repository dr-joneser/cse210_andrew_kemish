Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 100);

int guess = 0;

while (guess != number)
{
    Console.WriteLine(" ");
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    if (guess < number)
    {
        Console.Write("Higher");
    }
    else if (guess > number)
    {
        Console.Write("Lower");
    }
    else
    {
        Console.Write("You guessed it!");
    }
}