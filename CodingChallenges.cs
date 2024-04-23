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
