using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int userNumber;
        while (true)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();

            if (int.TryParse(userResponse, out userNumber) && userNumber == 0)
            {
                break;
            }
            else if (int.TryParse(userResponse, out userNumber))
            {
                numbers.Add(userNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        if (numbers.Count > 0)
        {
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        else
        {
            Console.WriteLine("No numbers to calculate average.");
        }

        // Part 3: Find the max
        if (numbers.Count > 0)
        {
            int max = numbers.Max();
            Console.WriteLine($"The max is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers to find max.");
        }
    }
}


