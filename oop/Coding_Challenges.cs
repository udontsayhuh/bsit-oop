using System;
using System.Collections;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    start:
        Console.WriteLine("CODING CHALLENGES\n");
        Console.WriteLine("1. ComputeSumProduct");
        Console.WriteLine("2. CountWords");
        Console.WriteLine("3. Arithmetic");
        Console.WriteLine("4. MultiplicationTable");
        Console.WriteLine("5. Cars");

        int chosen;

        while (true)
        {
            try
            {
                Console.Write("Enter choice: ");
                chosen = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                break;
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer!");
            }
        }

        switch (chosen)
        {
            case 1:
                ComputeSumProduct();
                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
                goto start;
                break;
            case 2:
                CountWords();
                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
                goto start;
                break;
            case 3:
                Arithmetic();
                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
                goto start;
                break;
            case 4:
                MultiplicationTable();
                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
                goto start;
                break;
            case 5:
                Cars();
                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
                goto start;
                break;
            default:
                Console.WriteLine("Invalid choice!");
                goto start;
        }

    }

    // First Challenge
    static void ComputeSumProduct()
    {
        int int1;
        int int2;
        int intSum;
        double double1;
        double double2;
        double doubleSum;
        double product;



        // Prompt for integers
        while (true)
        {
            try
            {
                Console.Write("Enter first int: ");
                int1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second int: ");
                int2 = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nInvalid input!");
                Console.WriteLine("Enter integers only!");
                Console.WriteLine("===============================");
            }
        }

        // Prompt for double values
        while (true)
        {
            try
            {
                Console.Write("Enter first double: ");
                double1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second double: ");
                double2 = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nInvalid input!");
                Console.WriteLine("Enter doubles only!");
                Console.WriteLine("===============================");
            }
        }

        // Output
        intSum = int1 + int2;
        doubleSum = double1 + double2;
        product = intSum * doubleSum;
        Console.WriteLine($"\nSum of integers: {int1} + {int2} = {intSum}");
        Console.WriteLine($"Sum of doubles: {double1} + {double2} = {doubleSum}");
        Console.WriteLine($"Product of sums: {intSum} * {doubleSum} = {product}");
    }


    // Second Challenge
    static void CountWords()
    {

        string str;
        string strUpperCase;
        int wordCount = 0;
        bool inWord = false; // flag to track if currently in a word


        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                if (!inWord)
                {
                    wordCount++;
                }
                inWord = true;
            }
            else
            {
                inWord = false;
            }

        }

        Console.WriteLine($"Number of words: {wordCount}");

    }


    // Third Challenge
    static void Arithmetic()
    {
    start:
    user_interface:
        Console.WriteLine("Select an arithmetic function\n");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("\nEnter choice: ");
        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if ((choice != '1') && (choice != '2') && (choice != '3') && (choice != '4'))
        {
            Console.WriteLine("Invaid choice!");
            goto user_interface;
        } else
        {
            Console.Clear();
        }

        double num1 = 0;
        double num2 = 0;
        double result = 0;


        while (true)
        {
            try
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Enter numbers only");
            }
        }

        switch (choice)
        {
            case '1':
                result = num1 + num2;
                break;
            case '2':
                result = num1 - num2;
                break;
            case '3':
                result = num1 * num2;
                break;
            case '4':
                result = num1 / num2;
                break;
        }


        Console.WriteLine($"Result: {result}");

        Console.WriteLine("\nDo you want to perform another action? <Yes or Any string>");
        string input = Console.ReadLine();
        

        if (input.ToUpper().Equals("YES"))
        {
            Console.Clear();
            goto start;
        }
        else
        {
            Console.WriteLine("Goodbye");
        }




    }

    static void MultiplicationTable()
    {
        int num;
        int multiplier;

        while (true)
        {
            try
            {
                Console.Write("Enter num: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter multiplier: ");
                multiplier = Convert.ToInt32(Console.ReadLine());

                break;
            }
            catch
            {
                Console.WriteLine("Please enter an integer only!");
            }
        }

        Console.WriteLine();

        // Print the multiplication table
        for (int i = 1; i <= multiplier; i++)
        {
            int result = num * i;
            Console.WriteLine($"{num} x {i} = {result}");
        }
    }

    static void Cars()
    {
        ArrayList cars = new ArrayList();

        cars.Add("Toyota");
        cars.Add("Honda");
        cars.Add("Tesla");
        cars.Add("Ford");
        cars.Add("Nissan");

        Console.WriteLine("Cars before:\n");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        // Sort the list
        cars.Sort();

        Console.WriteLine("=============================");
        Console.WriteLine("\nList of cars after sorting:\n");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }




}
