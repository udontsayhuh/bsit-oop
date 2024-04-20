using System;

namespace CalculatorApp
{
    // Class to perform basic arithmetic operations on multiple numbers
    class Calculator
    {
        private double[] numbers;
        private char[] operations;

        // Constructor to initialize class variables
        public Calculator()
        {
            numbers = new double[5];
            operations = new char[4]; // We need 4 operations between 5 numbers
        }

        // Method to input numbers and select operations from the user
        public void InputNumbersAndOperators()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                if (i < 4)
                {
                    Console.Write("Enter Operator (+, -, *, /): ");
                    operations[i] = Console.ReadLine()[0];
                }
            }
        }

        // Method to perform the selected arithmetic operations
        public void PerformCalculations()
        {
            // Compute sum of integers
            int sumIntegers = 0;
            for (int i = 0; i < 5; i++)
            {
                sumIntegers += (int)numbers[i]; // Casting to int for summing integers
            }
            Console.WriteLine($"Sum of integers: {sumIntegers}");

            // Compute sum of doubles
            double sumDoubles = 0;
            for (int i = 0; i < 5; i++)
            {
                sumDoubles += numbers[i]; // Summing doubles
            }
            Console.WriteLine($"Sum of doubles: {sumDoubles}");

            // Compute product of the sums
            double product = sumIntegers * sumDoubles;
            Console.WriteLine($"Product of sums: {product}");

            // Perform the sequence of operations on the numbers
            double result = numbers[0];
            for (int i = 0; i < 4; i++)
            {
                switch (operations[i])
                {
                    case '+':
                        result += numbers[i + 1];
                        break;
                    case '-':
                        result -= numbers[i + 1];
                        break;
                    case '*':
                        result *= numbers[i + 1];
                        break;
                    case '/':
                        if (numbers[i + 1] != 0)
                            result /= numbers[i + 1];
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    }

    // Main program class to run the calculator
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Welcome to The Calculator");

                calculator.InputNumbersAndOperators();
                calculator.PerformCalculations();

                Console.Write("Do you want to perform another calculation? (Y/N): ");
                char choice = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (choice != 'Y')
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
//CODE CHALLENGE NUMBER 2

using System;
using System.Text.RegularExpressions;

public class WordCounter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        int wordCount = CountWords(inputString);
        string upperCaseString = ConvertToUppercase(inputString);

        Console.WriteLine($"Number of words: {wordCount}");
        Console.WriteLine($"String in uppercase: {upperCaseString}");
    }

    public static int CountWords(string str)
    {
        // Define a regular expression pattern to match words
        Regex wordRegex = new Regex(@"\b\w+\b");

        // Count the matches (words) in the string
        int count = wordRegex.Matches(str).Count;

        return count;
    }

    public static string ConvertToUppercase(string str)
    {
        return str.ToUpper();
    }
}
// CODE CHALLENGE NUMBER 3

using System;

namespace CalculatorApp
{
    // Class to perform basic arithmetic operations on two numbers
    class Calculator
    {
        private double num1;
        private double num2;
        private char operation;

        // Constructor to initialize class variables
        public Calculator()
        {
            num1 = 0;
            num2 = 0;
            operation = ' ';
        }

        // Method to input two numbers and select arithmetic operation
        public void InputNumbersAndOperator()
        {
            
            Console.Write("Enter Operator (+, -, *, /): ");
            operation = Console.ReadLine()[0];
            
            Console.Write("Enter First Number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            

            Console.Write("Enter Second Number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
        }

        // Method to perform the selected arithmetic operation
        public void PerformCalculation()
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }

    // Main program class to run the calculator
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Welcome to The Calculator");

                calculator.InputNumbersAndOperator();
                calculator.PerformCalculation();

                Console.Write("Do you want to perform another calculation? (Y/N): ");
                char choice = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (choice != 'Y')
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
//CODE CHALLENGE NUMBER FOUR
using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Welcome to Multiplication Table Generator");

            int number = GetValidIntegerInput("Enter the number to be multiplied: ");
            int multiplier = GetValidIntegerInput("Enter the multiplier (up to which to print): ");

            DisplayMultiplicationTable(number, multiplier);

            continueProgram = PromptToContinue();
        }

        Console.WriteLine("Exiting the program. Goodbye!");
    }

    // Method to get a valid positive integer input from the user
    private static int GetValidIntegerInput(string message)
    {
        int input;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out input) && input > 0)
            {
                return input;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    // Method to display the multiplication table of a given number up to a specified multiplier
    private static void DisplayMultiplicationTable(int number, int multiplier)
    {
        Console.WriteLine($"Multiplication Table of {number} up to {multiplier}:");

        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    // Method to prompt the user if they want to continue generating multiplication tables
    private static bool PromptToContinue()
    {
        while (true)
        {
            Console.Write("Do you want to generate another multiplication table? (Y/N): ");
            char choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (choice == 'Y')
            {
                return true;
            }
            else if (choice == 'N')
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
            }
        }
    }
}
//CODE CHALLENGE NUMBER FIVE
using System;
using System.Collections;

public class Car
{
    public string Model { get; private set; }
    public string Make { get; private set; }
    public int Year { get; private set; }

    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}

public class Mslayer : Car
{
    public int CarCapacity { get; private set; }

    public Mslayer(string model, string make, int year, int carCapacity) : base(model, make, year)
    {
        CarCapacity = carCapacity;
    }
}

public class Another : Car
{
    public int CarCapacity { get; private set; }

    public Another(string model, string make, int year, int carCapacity) : base(model, make, year)
    {
        CarCapacity = carCapacity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayList carList = new ArrayList();

        // Add cars to the ArrayList
        carList.Add(new Car("Toyota Corolla", "Toyota", 2023));
        carList.Add(new Mslayer("Lamborghini Aventador", "Aventador S", 2017, 100));
        carList.Add(new Another("Porsche 911", "Porsche", 2023, 100));
        carList.Add(new Car("Honda Civic", "Honda", 2019));
        carList.Add(new Car("Ford Mustang", "Ford", 2018));

        // Display unsorted list of cars
        Console.WriteLine("Unsorted List of Cars:");
        DisplayCarList(carList);

        // Sort the ArrayList based on car years using the custom comparer
        carList.Sort(new CarComparer());

        // Display sorted list of cars
        Console.WriteLine("\nSorted List of Cars:");
        DisplayCarList(carList);
    }

    // Helper method to display list of cars
    static void DisplayCarList(ArrayList cars)
    {
        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.Model}, Make: {car.Make}, Year: {car.Year}");
            Console.WriteLine(); // Add a blank line for separation
        }
    }
}

// Custom comparer class to sort cars by year
public class CarComparer : IComparer
{
    public int Compare(object x, object y)
    {
        Car car1 = (Car)x;
        Car car2 = (Car)y;
        return car1.Year.CompareTo(car2.Year);
    }
}

