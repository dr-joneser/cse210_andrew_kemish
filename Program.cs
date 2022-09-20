using System.Collections.Generic;
Console.WriteLine("Enter a list of numbers, type 0 when finished.");
List<int> numbers = new List<int>();
int value = -1;
while (value != 0)
{
    Console.WriteLine("Enter Number: ");
    value = int.Parse(Console.ReadLine());
    if (value != 0)
    {
        numbers.Add(value);
    }
}
int sum = 0;
foreach (int num in numbers)
{
    sum += num;
}
Console.WriteLine($"The sum is {sum}");
int count = numbers.Count;
int average = (sum / count);
Console.WriteLine($"The average is {average}");
int best = 0;
foreach (int num in numbers)
{
    if (num > best)
    {
        best = num;
    }
}
Console.WriteLine($"The largest number is {best}");