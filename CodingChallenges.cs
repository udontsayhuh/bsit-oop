/*1. Write a C# program that contains method that accepts inputs from the user - that will
compute the sum of two integers and two doubles separately, and after showing the
result of the two sums, compute for the product of the sums - the result must be a
double data type.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter inputs
        Console.WriteLine(" ------------------------------");
        Console.WriteLine("|      Enter two Integers      |");
        Console.WriteLine(" ------------------------------");

        Console.Write("Enter first integer: ");
        int int1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int int2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" ------------------------------");
        Console.WriteLine("|      Enter two Doubles       |");
        Console.WriteLine(" ------------------------------");

        Console.Write("Enter first double: ");
        double double1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second double: ");
        double double2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" ------------------------------");

        // Computing the sum of two integers
        int intSum = AddIntegers(int1, int2);
        Console.Write($"Sum of integers: {intSum}");

        // Computing the sum of two doubles
        double doubleSum = AddDoubles(double1, double2);
        Console.Write($"Sum of doubles: {doubleSum}");

        // Computing the product of the sums
        double product = ComputeProduct(intSum, doubleSum);
        Console.Write($"Product of the sums: {product}");

        Console.ReadLine();
    }

    static int AddIntegers(int a, int b)
    {
        return a + b;
    }

    static double AddDoubles(double a, double b)
    {
        return a + b;
    }

    static double ComputeProduct(int intSum, double doubleSum)
    {
        return intSum * doubleSum;
    }
}



/*2. Write a C# program that accepts a string and will count the number of words in the
provided string and print the string in uppercase as a result.*/

using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.WriteLine("\nEnter a string: ");

        string inputString = Console.ReadLine();

        // Count the number of words in the input string
        int wordCount = CountWords(inputString);

        // Print the number of words in the input string
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Number of Words: {wordCount}");

        // Print the input string in uppercase
        string uppercaseString = inputString.ToUpper();
        Console.WriteLine($"String Words to Uppercase: \n{uppercaseString}");
        Console.WriteLine("---------------------------------------");

        Console.ReadLine();
    }

    // Method to count the number of words in a string
    static int CountWords(string str)
    {
        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }
}


/*3. Write a C# program that can perform basic arithmetic functions. (Addition,
Subtraction, Multiplication, and Division). The user must be allowed to select which
arithmetic function he/she wants to use, and then they will be prompted to enter only two numbers after
selecting the arithmetic function. Print the result afterwards, and then after printing
ask the user if he/she wants toperform another action or not. If yes, repeat the
program, if not terminate the program.*/

using System;

class Program
    {
        static void Main()
        {
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                Your Basic Calculator                  ");
        Console.WriteLine("-------------------------------------------------------");
        
        while (true)
            {
                Console.WriteLine("\nSelect an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                    break;

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
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
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Error: Division by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine($"Result: {result}\n");

            // Ask the user if they want to perform another calculation
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Do you want to perform another calculation? (yes/no): ");
                string answer = Console.ReadLine().ToLower();
                if (answer != "y"  && answer != "yes" && answer != "Y")
                    break;
            }
        }
    }



/*4. Write a C# program that takes two numbers as input: the first
number will be the number to be multiplied and the second
number will be the multiplier, and prints its multiplication table up
to the given second number (the multiplier).*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ---------------------------------------");
        Console.WriteLine("|     Enter two Numbers to Multiply     |");
        Console.WriteLine(" ---------------------------------------");

        // Prompt the user to enter inputs 
        Console.WriteLine("Enter the multiplicand: ");
        int multiplicand = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        // Print the multiplication table
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Multiplication table for {multiplicand} up to {multiplier}:");

        //calculates the product for each iteration
        for (int i = 1; i <= multiplier; i++)
        {
            int result = multiplicand * i;
            Console.WriteLine($"{multiplicand} * {i} = {result}");
        }

        Console.ReadLine();
    }
}




/*5. Write a C# program that demonstrates a list that contains 5 cars
and display a sorted listed after. (Using ArrayList are LinkedList is
allowed).*/

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        //Creating a list to store the list of cars
        ArrayList cars = new ArrayList();

        //adding the cars
        cars.Add("Cadillac");
        cars.Add("Toyota");
        cars.Add("Bentley");
        cars.Add("Ferarri");
        cars.Add("Mitsubishi");

        //displaying the orginal list of cars
        Console.WriteLine("------------------------------");
        Console.WriteLine("  The original list of cars   ");
        Console.WriteLine("------------------------------");
        DisplayList(cars);


        //sorting and displaying the list
        cars.Sort();
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("  The sorted list of cars     ");
        Console.WriteLine("------------------------------");
        DisplayList(cars);

        Console.ReadLine();
    }

    // here is the method of how to display the list content
    static void DisplayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}


