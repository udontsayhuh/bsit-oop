using System;

// Calculator class for addition and multiplication
class Calculator
{
    // Method to add two integers
    public int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber; // Returns the sum of two integers
    }

    // Method to add two doubles
    public double Add(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber; // Returns the sum of two doubles
    }

    // Method to multiply two numbers
    public double Multiply(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber; // Returns the product of two numbers
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt for user input
        Console.WriteLine("Enter two integers:");
        // Read the first integer from user input and convert it to int
        int firstInt = Convert.ToInt32(Console.ReadLine());
        // Read the second integer from user input and convert it to int
        int secondInt = Convert.ToInt32(Console.ReadLine());

        // Prompt for user input
        Console.WriteLine("Enter two doubles:");
        // Read the first double from user input and convert it to double
        double firstDouble = Convert.ToDouble(Console.ReadLine());
        // Read the second double from user input and convert it to double
        double secondDouble = Convert.ToDouble(Console.ReadLine());

        // Create an instance of the Calculator class
        Calculator calculator = new Calculator();

        // Calculate the sum of the two integers using the Add method for integers
        int sumInt = calculator.Add(firstInt, secondInt);
        // Display the sum of the integers
        Console.WriteLine("Sum of the integers: " + sumInt);

        // Calculate the sum of the two doubles using the Add method for doubles
        double sumDouble = calculator.Add(firstDouble, secondDouble);
        // Display the sum of the doubles
        Console.WriteLine("Sum of the doubles: " + sumDouble);

        // Calculate the product of the sums using the Multiply method
        double product = calculator.Multiply(sumInt, sumDouble);
        // Display the product of the sums
        Console.WriteLine("Product of the sums: " + product);
    }
}
