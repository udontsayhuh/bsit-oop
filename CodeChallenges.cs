using System;

class Program
{
    static void Main()
    {
        ComputeSums();
        CountWords();
        BasicArithmetic();
        MultiplicationTable();
        SortCars();
    }

    static void ComputeSums()
    {
        Console.WriteLine("\n=========================================");
        Console.WriteLine("            COMPUTING THE SUM            ");
        Console.WriteLine("=========================================");
        Console.WriteLine("Enter two integers:");
        int int1 = Convert.ToInt32(Console.ReadLine());
        int int2 = Convert.ToInt32(Console.ReadLine());
        int sumIntegers = int1 + int2;
        Console.WriteLine($"Sum of integers: {sumIntegers}");

        Console.WriteLine("\nEnter two doubles:");
        double double1 = Convert.ToDouble(Console.ReadLine());
        double double2 = Convert.ToDouble(Console.ReadLine());
        double sumDoubles = double1 + double2;
        Console.WriteLine($"Sum of doubles: {sumDoubles}");

        double product = sumIntegers * sumDoubles;
        Console.WriteLine($"Product of sums: {product}");
    }

    static void CountWords()
    {
        Console.WriteLine("\n\n=========================================");
        Console.WriteLine("              COUNT THE WORDS            ");
        Console.WriteLine("=========================================");
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Number of words: {words.Length}");
        Console.WriteLine($"Uppercase string: {input.ToUpper()}");
    }

    static void BasicArithmetic()
    {
        while (true)
        {
            Console.WriteLine("\n\n=========================================");
            Console.WriteLine("              BASIC ARITHMETIC              ");
            Console.WriteLine("=========================================");
            Console.WriteLine("Select an arithmetic function:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine(" ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
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
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Do you want to perform another action? (Y/N)");
            string input = Console.ReadLine();
            if (input.ToUpper() != "Y")
                break;
        }
    }

    static void MultiplicationTable()
    {
        Console.WriteLine("\n\n=========================================");
        Console.WriteLine("            MULTIPLICATION TABLE            ");
        Console.WriteLine("=========================================");
        Console.WriteLine("Enter a number to be multiplied:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the multiplier:");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    static void SortCars()
    {
        Console.WriteLine("\n\n=========================================");
        Console.WriteLine("             SORTING THE CARS            ");
        Console.WriteLine("=========================================");
        string[] cars = { "Aston Martin", "Mercedes-Benz", "Rolls Royce", "Porsche", "Lamborghini" };
        Array.Sort(cars);
        Console.WriteLine("Sorted list of cars:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        Console.WriteLine("\n------THANK YOU FOR USING THE PROGRAM!------\n");
    }
}
