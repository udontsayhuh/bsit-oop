//ZAINA E. GHAZI
//BSIT 2-2
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 1 <<<<<\n\n");

        int sumInt, num1, num2;
        double numA, numB, sumDouble, productOfSums;

        Console.Write("Enter an Integer: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter another Integer: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter a Double value: ");
        numA = double.Parse(Console.ReadLine());
        Console.Write("Enter another Double value: ");
        numB = double.Parse(Console.ReadLine());

        sumInt = num1 + num2;
        sumDouble = numA + numB;
        productOfSums = sumInt * sumDouble;

        Console.WriteLine("\n\nInteger sum: " + sumInt);
        Console.WriteLine("Doubles sum: " + sumDouble);
        Console.WriteLine("Product of sums: " + productOfSums);

        Console.WriteLine("\n\n\t\t>>Press any key to continue the next challenge...");
        Console.ReadKey();
        Console.Clear();
        // =========================================================================

        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 2 <<<<<\n\n");

        Console.Write("Enter a String: ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Original String: " + str1);

        int length1 = str1.Length;
        Console.WriteLine("Length of String: " + length1);

        string upper1 = str1.ToUpper();
        Console.WriteLine("Converted String: " + upper1);

        Console.WriteLine("\n\n\t\t>>Press any key to continue to the next challenge...");
        Console.ReadKey();
        Console.Clear();
        // =========================================================================

        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 3 <<<<<\n\n");

        string operatorSymbol, anotherSession;
        double a, b;

        while (true)
        {
            Console.Write("Enter the first Number: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write(">>ERROR: Please enter a numerical value.\n\nEnter the first number: ");
            }

            Console.Write("Enter an Operator symbol (+ - / *): ");
            operatorSymbol = Console.ReadLine();
            while (operatorSymbol != "+" && operatorSymbol != "-" && operatorSymbol != "*" && operatorSymbol != "/")
            {
                Console.Write(">>ERROR: \n\nEnter a valid Operator symbol (+ - / *): ");
                operatorSymbol = Console.ReadLine();
            }


            Console.Write("Enter the second Number: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write(">>ERROR: Please enter a numerical value.\nEnter the second Number: ");
            }

            switch (operatorSymbol)
            {
                case "+":
                    Console.WriteLine($"\n\n\t\tResult{a} + {b} = {(a + b)}");
                    break;
                case "-":
                    Console.WriteLine($"\n\n\t\t{a} - {b} = {(a - b)}");
                    break;
                case "*":
                    Console.WriteLine($"\n\n\t\t{a} * {b} = {(a * b)}");
                    break;
                case "/":
                    if (b != 0)
                    {
                        Console.WriteLine($"\n\n\t\t{a} / {b} = {(a / b)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nERROR: Cannot divide by ZERO.");
                        break;
                    }
            }

            while (true)
            {
                Console.Write("\n\n\t\t>>Do you wish to continue? (y/n): ");
                anotherSession = Console.ReadLine().ToLower();
                if (anotherSession == "y" || anotherSession == "n")
                {
                    break;
                }
                Console.WriteLine("\nERROR: Enter 'y' or 'n'.");
            }
            if (anotherSession == "n")
            {
                break;
            }
        }
        Console.WriteLine("\n\n\t\t>>Press any key to continue to the next challenge...");
        Console.ReadKey();
        Console.Clear();
        //=========================================================================================

        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 4 <<<<<\n\n");

        int baseNum, multiplier;

        Console.Write("Enter the base Number: ");
        baseNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Multiplier: ");
        multiplier = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("======================================\n\n\tMULTIPLICATION TABLE\n");
        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"\t {baseNum} * {i} = {i * baseNum}");
        }

        Console.WriteLine("\n\n\t\t>>Press any key to continue to the next challenge...");
        Console.ReadKey();
        Console.Clear();
        //=========================================================================================

        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 5 <<<<<\n\n");

        ArrayList cars = new ArrayList();
        string car;
        int j;

        for (j = 0; j < 5; j++)
        {
            Console.Write($"Enter any Car #{j + 1}: ");
            car = Console.ReadLine();
            cars.Add(car);
        }
        Console.WriteLine("\n\t>>Original list of Cars<<");
        for (j = 0; j < cars.Count; ++j)
        {
            Console.WriteLine("\t" + cars[j]);
        }

        cars.Sort();
        Console.WriteLine("\n\n\t>>Sorted list of Cars<<");
        for (j = 0; j < cars.Count; ++j)
        {
            Console.WriteLine("\t" + cars[j]);
        }
        Console.ReadKey();
        Console.Clear();
    }
}
