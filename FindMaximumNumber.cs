using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a list of integers
        Console.WriteLine("Enter a list of integers, separated by spaces:");
        string input = Console.ReadLine();

        // Convert the input string to an array of integers
        int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

        // Find the maximum number in the array
        int maxNumber = FindMaximum(numbers);

        // Output the result
        Console.WriteLine($"The maximum number is: {maxNumber}");
    }

    // Function to find the maximum number in the array
    static int FindMaximum(int[] numbers)
    {
        int max = numbers[0];  // Start with the first number as the maximum

        // Loop through the array to find the largest number
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number; // Update the maximum if a larger number is found
            }
        }

        return max; // Return the maximum number
    }
}
