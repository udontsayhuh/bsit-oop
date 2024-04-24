using System;
using System.Collections;

class coding
{

    static void Main(String[] args)
    {
        Console.WriteLine("Choose an option to run a program: ");
        Console.WriteLine("1 - Compute the Sum and Product.");
        Console.WriteLine("2 - Count the Words and print the Uppercase.");
        Console.WriteLine("3 - Basic Arithmetic Operations.");
        Console.WriteLine("4 - Print the Multipilcation Table");
        Console.WriteLine("5 - Sort a List of Car.");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ComputetheSumandProduct();
                break;
            case 2:
                CountWordsandConvertUppercase();
                break;
            case 3:
                BasicArithmeticOperation();
                break;
            case 4:
                MultiplicationTable();
                break;
            case 5:
                SortListofCars();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
    //Option1: Compute the Sum and Product
    static void ComputetheSumandProduct()
    {
        Console.WriteLine("Enter two integers: ");
        int int1 = Convert.ToInt32(Console.ReadLine());
        int int2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter two Doubles:");
        double double1 = Convert.ToDouble(Console.ReadLine());
        double double2 = Convert.ToDouble(Console.ReadLine());

        //Compute sums
        int sumInt = int1 + int2;
        double sumDoubles = double1 + double2;

        //Display sums
        Console.WriteLine($"Sum of integers: {sumInt}");
        Console.WriteLine($"Sum of doubles: {sumDoubles}");

        //Compute product of sums
        double product = sumInt * sumDoubles;

        //Display product
        Console.WriteLine($"Product of Sums:{product}", product);
    }
    //Option2: Count the Words and print the Uppercase.
    static void CountWordsandConvertUppercase()
    {
        Console.WriteLine("Enter a String:");
        string input = Console.ReadLine();

        //Count the number
        int wordCount = CountWords(input);

        //Convert the string to uppercase
        string uppercaseString = input.ToUpper();

        //Print the result
        Console.WriteLine($"Number of Words: {wordCount}");
        Console.WriteLine($"Uppercase string: {uppercaseString}");
    }
    static int CountWords(string input)
    {
        // Split the string into words
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Return the number of words
        return words.Length;
    }


    //Option 3: Perform basic arithmetic operations
    static void BasicArithmeticOperation()
    {
        bool repeat = true;
        while (repeat)
        {
            // Display menu
            Console.WriteLine("Select an arithmetic operation:");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("0");
            // Get user's choice
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: // Addition
                    Addition();
                    break;
                case 2: // Subtraction
                    Subtraction();
                    break;
                case 3: // Multiplication
                    Multiplication();
                    break;
                case 4: // Division
                    Division();
                    break;
                case 5: // Exit
                    repeat = false;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
            if (repeat)
            {
                // Ask the user if they want to perform another action
                Console.Write("Do you want to perform another action? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                if (response != "yes")
                {
                    repeat = false;
                    Console.WriteLine("Exiting program...");
                }
            }
        }
    }
    static void Addition()
    {
        Console.WriteLine("Enter two numbers to add:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
    }

    static void Subtraction()
    {
        Console.WriteLine("Enter two numbers to subtract:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
    }

    static void Multiplication()
    {
        Console.WriteLine("Enter two numbers to multiply:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
    }

    static void Division()
    {
        Console.WriteLine("Enter two numbers to divide:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
        {
            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    //Option 4: Print Multipilication Table
    static void MultiplicationTable()
    {
        // Prompt the user to enter the number to be multiplied and the multiplier
        Console.WriteLine("Enter the number to be multiplied:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the multiplier:");
        int multiplier = Convert.ToInt32(Console.ReadLine());
        // Print the multiplication table
        MultiplicationTable(number, multiplier);
    }
    static void MultiplicationTable(int number, int multiplier)
    {
        // Iterate through the multipliers from 1 to the specified multiplier
        for (int i = 1; i <= multiplier; i++)
        {
            // Calculate the product
            int result = number * i;
            // Print the multiplication expression and result
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }


    //Sort of List cars
    static void SortListofCars()
    {
        //arraylist to store a car
        ArrayList cars = new ArrayList();
        //Add cars to the list
        cars.Add("Toyota");
        cars.Add("Mercedes");
        cars.Add("BMW");
        cars.Add("Honda");
        cars.Add("Nissan");
        cars.Add("Ford");
        cars.Add("Ferarri");
        Console.WriteLine("Original list of cars: ");
        DisplayList(cars);
        // Sort the list
        cars.Sort();
        // Display the sorted list
        Console.WriteLine("\nSorted list of cars:");
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
