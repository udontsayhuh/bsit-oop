using System;

class NumberSumCalculator
{
    // Method to calculate the sum of numbers from 1 to a given input
    public int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Create an instance of NumberSumCalculator
        NumberSumCalculator calc = new NumberSumCalculator();

        // Calculate the sum of numbers from 1 to the input number
        int sum = calc.CalculateSum(num);

        // Display the sum using string interpolation
        Console.WriteLine("Sum of numbers from 1 to {0}: {1}", num, sum);
    }
}
