// Challenge No. 1
// Write a C# program that contains method that accepts inputs from the user - that will compute the sum of two integers and two doubles separately, and after showing the result of the two sums, compute for the product of the sums - the result must be a double data type.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers (separated by a comma):");
        string[] intInputs = Console.ReadLine().Split(',');
        int int1 = Convert.ToInt32(intInputs[0]);
        int int2 = Convert.ToInt32(intInputs[1]);

        Console.WriteLine("Enter two doubles (separated by a comma):");
        string[] doubleInputs = Console.ReadLine().Split(',');
        double double1 = Convert.ToDouble(doubleInputs[0]);
        double double2 = Convert.ToDouble(doubleInputs[1]);

        int intSum = Sum(int1, int2);
        double doubleSum = Sum(double1, double2);

        Console.WriteLine($"Sum of Integers: {intSum}");
        Console.WriteLine($"Sum of Doubles: {doubleSum}");

        double product = intSum * doubleSum;

        Console.WriteLine($"Product of the sums: {product}");
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }

    static double Sum(double a, double b)
    {
        return a + b;
    }
}


// Challenge No.2
// Write a C# program that accepts a string and will count the number of words in the provided string and print the string in uppercase as a result.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string myString = Console.ReadLine();

        int wordCount = CountWords(myString);

        Console.WriteLine($"Number of words: {wordCount}");

        string upperCaseString = myString.ToUpper();
        Console.WriteLine($"String in uppercase: {upperCaseString}");
    }

    static int CountWords(string str)
    {
        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}


// Challenge No.3
// Write a C# program that can perform basic arithmetic functions. (Addition, Subtraction, Multiplication, and Division). The user must be allowed to select which arithmetic function he/she wants to use, and then they will be prompted to enter only two numbers after selecting the arithmetic function. Print the result afterwards, and then after printing ask the user if he/she wants toperform another action or not. If yes, repeat the program, if not terminate the program.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an Arithmetic Operation:");
            Console.WriteLine("Addition (+)");
            Console.WriteLine("Subtraction (-)");
            Console.WriteLine("Multiplication(*)");
            Console.WriteLine("Division (/)");
            Console.WriteLine("Exit");
            Console.Write("\nEnter your choice (Put the operation or exit to stop): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    PerformAddition();
                    break;
                case "-":
                    PerformSubtraction();
                    break;
                case "*":
                    PerformMultiplication();
                    break;
                case "/":
                    PerformDivision();
                    break;
                case "exit":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number a valid choice.");
                    break;
            }

            Console.Write("\nDo you want to perform another operation? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                Console.WriteLine("Exiting program...");
                return;
            }

            Console.WriteLine();
        }
    }

    static void PerformAddition()
    {
        Console.Write("\nEnter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"Result of addition: {result}");
    }

    static void PerformSubtraction()
    {
        Console.Write("\nEnter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine($"Result of subtraction: {result}");
    }

    static void PerformMultiplication()
    {
        Console.Write("\nEnter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"Result of multiplication: {result}");
    }

    static void PerformDivision()
    {
        Console.Write("\nEnter the dividend: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            double result = num1 / num2;
            Console.WriteLine($"Result of division: {result}");
        }
    }
}


// Challenge No.4
// Write a C# program that takes two numbers as input: the first number will be the number to be multiplied and the second number will be the multiplier, and prints its multiplication table up to the given second number (the multiplier)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number to be Multiplied: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Multiplier: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication table for {num1} up to {num2}:");
        for (int i = 1; i <= num2; i++)
        {
            int result = num1 * i;
            Console.WriteLine($"{num1} x {i} = {result}");
        }
    }
}


// Challenge No.5
// Write a C# program that demonstrates a list that contains 5 cars and display a sorted listed after. (Using ArrayList are LinkedList is allowed)

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList cars = new ArrayList();

        cars.Add("Land Rover");
        cars.Add("Mercedes-Benz");
        cars.Add("Bugatti");
        cars.Add("Tesla");
        cars.Add("Maybach");

        Console.WriteLine("List of cars (unsorted):");
        DisplayList(cars);

        cars.Sort();

        Console.WriteLine("\nList of cars (sorted):");
        DisplayList(cars);
    }

    static void DisplayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
