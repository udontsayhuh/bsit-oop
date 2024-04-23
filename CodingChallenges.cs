// #1

/*

using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;
        double num3, num4;

        num1 = IntValidation("Enter 1st number (integer type): ");
        num2 = IntValidation("Enter second number (integer type): ");
        Console.Clear();
        num3 = DoubleValidation("Enter third number (double type): ");
        num4 = DoubleValidation("Enter fourth number (double type): ");

        int sumInt = Sum1(num1, num2);
        double sumDouble = Sum2(num3, num4);

        double product = SumsProduct(sumInt, sumDouble);

        Console.WriteLine($"Sum of integers (num1 + num2): {sumInt}");
        Console.WriteLine($"Sum of doubles (num3 + num4): {sumDouble}");
        Console.WriteLine($"Product of sums (formatted to 5 decimals max): {product:F5}");
    }

    static int IntValidation(string message)
    {
        int result;
        bool isValidInput;
        do
        {
            Console.Write(message);
            isValidInput = int.TryParse(Console.ReadLine(), out result);
            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (!isValidInput);
        return result;
    }

    static double DoubleValidation(string message)
    {
        double result;
        bool isValidInput;
        do
        {
            Console.Write(message);
            isValidInput = double.TryParse(Console.ReadLine(), out result);
            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid double.");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (!isValidInput);
        return result;
    }

    static int Sum1(int a, int b)
    {
        return a + b;
    }

    static double Sum2(double a, double b)
    {
        return a + b;
    }

    static double SumsProduct(int intSum, double doubleSum)
    {
        return intSum * doubleSum;
    }

}

*/


// 2

/*

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string userInput = Console.ReadLine();

        int wordCount = CountWords(userInput);

        Console.WriteLine($"Word count: {wordCount}");
        Console.WriteLine($"All caps output: {userInput.ToUpper()}");
    }

    static int CountWords(string userInput)
    {
        int count = 0;
        bool isWord = false;

        foreach (char c in userInput)
        {
            if (char.IsWhiteSpace(c))
            {
                isWord = false;
            }
            else if (!isWord)
            {
                count++;
                isWord = true;
            }
        }

        return count;
    }
}

*/

// #3

/*

using System;

class Program
{
    static void Main(string[] args)
    {
        bool tryAgain = true;
        while (tryAgain)
        {
            Console.Clear();
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUBTRACT");
            Console.WriteLine("3. MULTIPLY");
            Console.WriteLine("4. DIVIDE");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid CHOICE! Choose between 1 to 4 ONLY!");
                ClearScreen();
                Console.Clear();
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. SUBTRACT");
                Console.WriteLine("3. MULTIPLY");
                Console.WriteLine("4. DIVIDE");
            }

            double num1, num2;
            while (true)
            {
                Console.Write("Enter the first number: ");
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    ClearScreen();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid INPUT! Numbers only!");
                    ClearScreen();
                }
            }

            while (true)
            {
                Console.Write("Enter the second number: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    ClearScreen();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid INPUT! Numbers only!");
                    ClearScreen();
                }
            }

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"the sum of {num1} and {num2} is: {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"the difference of {num1} and {num2} is: {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"the product of {num1} and {num2} is: {result}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number.");
                        break;
                    }
                    result = num1 / num2;
                    Console.WriteLine($"the quotient of {num1} and {num2} is: {result}");
                    break;
            }

            string response;
            while (true)
            {
                Console.Write("Do you want to try again? (yes/no): ");
                response = Console.ReadLine().ToLower();
                if (response == "yes" || response == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid INPUT! yes or no ONLY!.");
                    ClearScreen();
                }
            }

            tryAgain = (response == "yes");
        }
    }

    static void ClearScreen()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}

*/

// #4

/*

using System;

class Program
{
    static void Main(string[] args)
    {
        bool tryAgain = true;
        while (tryAgain)
        {
            Console.Clear();
            Console.WriteLine("Multiplication Table Generator");
            Console.WriteLine("------------------------------");

            double numberToMultiply;
            int multiplier;
            while (true)
            {
                Console.Write("Enter the number to be multiplied: ");
                if (double.TryParse(Console.ReadLine(), out numberToMultiply))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid INPUT! NUMBER only!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Multiplication Table Generator");
                    Console.WriteLine("------------------------------");
                }
            }

            while (true)
            {
                Console.Write("Enter the multiplier (the number up to which the table will be printed): ");
                if (int.TryParse(Console.ReadLine(), out multiplier))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid INPUT! NUMBER only!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Multiplication Table Generator");
                    Console.WriteLine("------------------------------");
                }
            }

            Console.Clear();
            Console.WriteLine($"Multiplication Table for {numberToMultiply} up to {multiplier}:");
            Console.WriteLine("----------------------------------------------");

            int increment = (multiplier > 0) ? 1 : -1;
            for (int i = 1; i <= Math.Abs(multiplier); i++)
            {
                int currentMultiplier = i * increment;
                double result = numberToMultiply * currentMultiplier;
                Console.WriteLine($"{numberToMultiply} * {currentMultiplier} = {result}");
            }

            string response;
            while (true)
            {
                Console.Write("Do you want to try again? (yes/no): ");
                response = Console.ReadLine().ToLower();
                if (response == "yes" || response == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! yes or no ONLY!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            tryAgain = (response == "yes");
        }
    }
}

*/

// # 5

/*

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> cars = new List<string>();

        Console.WriteLine("Enter 5 cars:");

        for (int i = 0; i < 5; i++)
        {
            string input;
            do
            {
                Console.Write($"Car {i + 1}: ");
                input = Console.ReadLine().Trim();
                Console.Clear();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid INPUT! Input cannot be EMPTY or be SPACES!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (string.IsNullOrWhiteSpace(input));

            cars.Add(input);
        }

        cars.Sort();

        Console.WriteLine("\nCars in alphabetical order:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}

*/
