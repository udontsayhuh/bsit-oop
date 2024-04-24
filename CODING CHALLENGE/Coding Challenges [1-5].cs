using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            //MENU SELECTION
            Console.Clear();
            Console.WriteLine("\nCODING CHALLENGE COMPILATION!  \n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Word Counter");
            Console.WriteLine("3. Calculator");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Array Sort");
            Console.Write("\n");
            Console.Write("Pick a number [1-5]: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    WordCounter();
                    break;
                case 3:
                    Calculator();
                    break;
                case 4:
                    MultiplicationTable();
                    break;
                case 5:
                    ArraySort();
                    break;
                default:
                    Console.WriteLine("Sorry, please try again!");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("");
                Console.WriteLine("Wanna select another menu? (Y/N): ");
                string response;
                do
                {
                    response = Console.ReadLine().Trim().ToUpper();
                } while (response != "Y" && response != "N");

                if (response == "N")
                {
                    Console.WriteLine("\nOkay, bye bye! (⁀ᗢ⁀)");
                    exit = true;
                }
            }

        }
    }

    /*------------------------------ITEM NUMBER 1------------------------------*/

    static void Addition()
    {
        Console.Clear();
        Console.WriteLine("ADDITION OF INT AND DOUBLE \n");

        int int1 = GetIntegerInput("Enter your first integer: ");
        int int2 = GetIntegerInput("Now your second integer: ");
        Console.WriteLine();
        Console.WriteLine("");

        double double1 = GetDoubleInput("Next, enter your first double: ");
        double double2 = GetDoubleInput("Now your second double: ");
        Console.WriteLine();
        Console.WriteLine("");

        int intSum = int1 + int2;
        double doubleSum = double1 + double2;
        double product = (double)intSum * doubleSum;

        Console.WriteLine($"SUM OF INTEGERS: {intSum}");
        Console.WriteLine($"SUM OF DOUBLES: {doubleSum}");
        Console.WriteLine($"PRODUCT OF SUMS: {product}");
    }

    //Error Handling Section
    static int GetIntegerInput(string message)
    {
        int value = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (int.TryParse(input, out value))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Uh oh, invalid input! INTEGER ONLY!");
            }
        }

        return value;
    }

    static double GetDoubleInput(string message)
    {
        double value = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (double.TryParse(input, out value))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Uh oh, invalid input! DOUBLES ONLY!");
            }
        }

        return value;
    }


    /*------------------------------ITEM NUMBER 2------------------------------*/

    static void WordCounter()
    {
        Console.Clear();
        Console.WriteLine("WORD COUNTER \n");
        Console.Write("Enter your sentence here: \n");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        Console.WriteLine($"\nNumber of words: {wordCount}");
        Console.WriteLine($"I said, {input.ToUpper()}!");
    }

    /*------------------------------ITEM NUMBER 3------------------------------*/

    static void Calculator()
    {
        Console.Clear();
        Console.WriteLine("BASIC CALCULATOR \n");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("\nPlease choose an arithmetic operation (1-4): ");
        int operation = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;
        switch (operation)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Is that even an operation?!");
                return;
        }

        Console.WriteLine($"Result: {result}");

        Console.Write("Any other calculations? (Y/N): ");
        string choice = Console.ReadLine().ToUpper();
        if (choice != "Y")
            return;
    }

    /*------------------------------ITEM NUMBER 4------------------------------*/

    static void MultiplicationTable()
    {
        Console.Clear();
        Console.WriteLine("MULTIPLICATION TABLE \n");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the multiplier: ");
        int multiplier = int.Parse(Console.ReadLine());

        Console.WriteLine($"MULTIPLICATION TABLE FOR {number} UP TO {multiplier}:");
        for (int i = 1; i <= multiplier; i++)
        {
            int product = number * i;
            Console.WriteLine($"{number} x {i} = {product}");
        }
    }

    /*------------------------------ITEM NUMBER 5------------------------------*/

    static void ArraySort()
    {
        Console.Clear();
        Console.WriteLine("ARRAY SORT \n");
        ArrayList cars = new ArrayList() { "Porsche", "Tesla", "Chevrolet", "Ford", "Volvo" };

        Console.WriteLine("UNSORTED LIST: ");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }

        cars.Sort();

        Console.WriteLine("\nSORTED LIST: ");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
