using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 1 <<<<<\n\n");

        int sumInt, num1, num2;
        double numA, numB, sumDouble, productOfSums;

        Console.Write("Enter integer value: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter another integer value: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter double value: ");
        numA = double.Parse(Console.ReadLine());
        Console.Write("Enter another double value: ");
        numB = double.Parse(Console.ReadLine());

        sumInt = num1 + num2;
        sumDouble = numA + numB;
        productOfSums = sumInt * sumDouble;

        Console.WriteLine("\n\nInteger sum: " + sumInt);
        Console.WriteLine("Doubles sum: " + sumDouble);
        Console.WriteLine("Product of sums: " + productOfSums);

        Console.WriteLine("\n\n\t\t>>press any key to go to the next challenge!");
        Console.ReadKey();
        Console.Clear();
        // =========================================================================

        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 2 <<<<<\n\n");

        Console.Write("Enter string: ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Original string: " + str1);

        int length1 = str1.Length;
        Console.WriteLine("Length of string: " + length1);

        string upper1 = str1.ToUpper();
        Console.WriteLine("Converted string: " + upper1);

        Console.WriteLine("\n\n\t\t>>press any key to go to the next challenge!");
        Console.ReadKey();
        Console.Clear();
        // =========================================================================

        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 3 <<<<<\n\n");

        string operatorSymbol, anotherSession;
        double a, b;

        while (true)
        {
            Console.Write("Enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write(">>Error! Please enter a numerical value.\n\nEnter the first number: ");
            }

            Console.Write("Enter operator symbol (+ - / *): ");
            operatorSymbol = Console.ReadLine();
            while (operatorSymbol != "+" && operatorSymbol != "-" && operatorSymbol != "*" && operatorSymbol != "/")
            {
                Console.Write(">>Error! \n\nEnter a valid operator symbol (+ - / *): ");
                operatorSymbol = Console.ReadLine();
            }


            Console.Write("Enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write(">>Error! Please enter a numerical value.\nEnter the second number: ");
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
                        Console.WriteLine("\nError! Cannot divide by zero.");
                        break;
                    }
            }

            while (true)
            {
                Console.Write("\n\n\t\t>>Do you want to start anotehr session?(y/n): ");
                anotherSession = Console.ReadLine().ToLower();
                if (anotherSession == "y" || anotherSession == "n")
                {
                    break;
                }
                Console.WriteLine("\nError! Enter 'y' or 'n'.");
            }
            if (anotherSession == "n")
            {
                break;
            }
        }
        Console.WriteLine("\n\n\t\t>>press any key to go to the next challenge!");
        Console.ReadKey();
        Console.Clear();
        //=========================================================================================

        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 4 <<<<<\n\n");

        int baseNum, multiplier;

        Console.Write("Enter the base number: ");
        baseNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the multiplier: ");
        multiplier = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("======================================\n\n\tMULTIPLICATION TABLE\n");
        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"\t {baseNum} * {i} = {i * baseNum}");
        }

        Console.WriteLine("\n\n\t\t>>press any key to go to the next challenge!");
        Console.ReadKey();
        Console.Clear();
        //=========================================================================================

        Console.WriteLine("\t\t>>>>> CODING CHALLENGE 5 <<<<<\n\n");

        ArrayList cars = new ArrayList();
        string car;
        int j;

        for (j = 0; j < 5; j++)
        {
            Console.Write($"Enter car #{j + 1}: ");
            car = Console.ReadLine();
            cars.Add(car);
        }
        Console.WriteLine("\n\t>>List of cars<<");
        for (j = 0; j < cars.Count; ++j)
        {
            Console.WriteLine("\t" + cars[j]);
        }

        cars.Sort();
        Console.WriteLine("\n\n\t>>Sorted list of cars<<");
        for (j = 0; j < cars.Count; ++j)
        {
            Console.WriteLine("\t" + cars[j]);
        }
        Console.ReadKey();
        Console.Clear();
    }
}
