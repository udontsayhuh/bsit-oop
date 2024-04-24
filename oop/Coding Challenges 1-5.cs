//Write a C# program that contains a method that accepts inputs from the user - that will compute the sum of two integers and two doubles separately,
//and after showing the result of the two sums, compute the product of the sums - the result must be a double data type.

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CODE CHALLENGES ONE\n");
        Console.WriteLine("Enter two integers:");
        int int1 = Convert.ToInt32(Console.ReadLine());
        int int2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter two doubles:");
        double double1 = Convert.ToDouble(Console.ReadLine());
        double double2 = Convert.ToDouble(Console.ReadLine());

        int sumInt = int1 + int2;  // Compute the sum of two integers
        Console.WriteLine($"Sum of integers: {sumInt}");

        double sumDouble = double1 + double2;  // Compute the sum of two doubles
        Console.WriteLine($"Sum of doubles: {sumDouble}");

        double product = sumInt * sumDouble; // Compute the product of the sum
        Console.WriteLine($"Product of the sums: {product}");
    }
}

//Write a C# program that accepts a string and will count the number of words in the provided string and print the string in uppercase as a result.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CODE CHALLENGES TWO\n");
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string uppercaseString = input.ToUpper(); // Convert to uppercase
        Console.WriteLine($"\nUppercase string: {uppercaseString}");

        int wordCount = CountWords(input); // Count the number of words 
        Console.WriteLine($"Number of words: {wordCount}");
    }

    static int CountWords(string input)
    {
        // whitespace
        string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        return words.Length;  // Return yung words count
    }
}

//Write a C# the program can perform basic arithmetic functions. (Addition Subtraction, Multiplication, and Division).
//The user must be allowed to select which arithmetic function he/she wants to use, and then they will be prompted to enter only two numbers after selecting the arithmetic function.
//Print the result afterwards, and then after printing ask the user if he/she wants to perform another action or not. If yes, repeat the program, if not terminate the program.
using System;

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("CODE CHALLENGES THREE \n");
            Console.WriteLine("Select an arithmetic function:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/) \n");
            Console.Write("---------------------------------------------------\n");

            Console.Write("Enter your choice (1-4): "); // Get user's choice
            int choice = Convert.ToInt32(Console.ReadLine());

            // User inputs
            Console.Write("\n Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"\n Result: {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"\n Result: {num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"\n Result: {num1} * {num2} = {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"\n Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("\nError!!!!!! Division by zero!");
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid choice!!!!");
                    break;
            }

            Console.Write("\n\nDo you want to perform another action? (yes/no): "); // Ask the user if they want to perform another action
            string continueChoice = Console.ReadLine().ToLower();
            repeat = (continueChoice == "yes" || continueChoice == "y");
        }
    }
}



//Write a C# program that takes two numbers as input: the first number will be the number to be multiplied and the second number will be the multiplier,
//and prints its multiplication table up to the given second number (the multiplier). 
using System;

class MultiplicationTablePrinter
{
    static void Main(string[] args)
    {
        Console.WriteLine("CODE CHALLENGES FOUR \n");
        Console.Write("Enter the base number: ");
        int baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nMultiplication table for {baseNumber} up to {multiplier}:");  //multiplication table
        for (int i = 1; i <= multiplier; i++)
        {
            int result = baseNumber * i;
            Console.WriteLine($"{baseNumber} * {i} = {result}");
        }
    }
}


//Write a C# program that demonstrates a list that contains 5 cars and display a sorted listed after. (Using ArrayList are LinkedList is allowed).

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList carList = new ArrayList();

        carList.Add("Toyota");
        carList.Add("Honda");
        carList.Add("Ford");
        carList.Add("BMW");
        carList.Add("Mercedes");

        Console.WriteLine("CODE CHALLENGES FIVE \n");
        Console.WriteLine("Original list of cars:"); //orig list
        DisplayList(carList);

        carList.Sort(); //sort

        Console.WriteLine("\nSorted list of cars:"); //sorted list
        DisplayList(carList);
    }
    static void DisplayList(ArrayList list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}

