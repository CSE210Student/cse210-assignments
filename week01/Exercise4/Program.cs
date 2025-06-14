using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberUser = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            numberUser = int.Parse(userInput);
            if (numberUser != 0)
            {
                numbers.Add(numberUser);
            }
        } while (numberUser != 0);

        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }
        }

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}