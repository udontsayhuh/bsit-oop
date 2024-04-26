//1. Write a C# program that contains method that accepts inputs from the user - that will
//compute the sum of two integers and two doubles separately, and after showing the
//result of the two sums, compute for the product of the sums - the result must be a
//double data type.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Challenge #1 \n");
        // Prompt the user to enter two integers
        Console.WriteLine("Enter two integers:");
        // Read the input from the user and parse it into integer variables
        int int1 = int.Parse(Console.ReadLine());
        int int2 = int.Parse(Console.ReadLine());

        // Prompt the user to enter two doubles
        Console.WriteLine("Enter two doubles:");
        // Read the input from the user and parse it into double variables
        double double1 = double.Parse(Console.ReadLine());
        double double2 = double.Parse(Console.ReadLine());

        // Calculate the sum of the integers
        int sumOfIntegers = int1 + int2;
        // Calculate the sum of the doubles
        double sumOfDoubles = double1 + double2;
        // Calculate the product of the sums
        double product = sumOfIntegers * sumOfDoubles;

        // Display the sum of the integers
        Console.WriteLine($"Sum of integers: {sumOfIntegers}");
        // Display the sum of the doubles
        Console.WriteLine($"Sum of doubles: {sumOfDoubles}");
        // Display the product of the sums
        Console.WriteLine($"Product of sums: {product}");
    }
}


//2. Write a C# program that accepts a string and will count the number of words in the
//provided string and print the string in uppercase as a result.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Challenge #2 \n");
        Console.WriteLine("Enter a String w/ Space per Character:");
        string input = Console.ReadLine();
        
        // Split the input string into words based on whitespace characters and count the number of words then
        // print the number of characters along with the uppercase version of the input string
        Console.WriteLine($"{input.Split().Length} Number of Characters for the String: {input.ToUpper()}");
        
    }
}

//3. Write a C# program that can perform basic arithmetic functions. (Addition,
//Subtraction, Multiplication, and Division). The user must be allowed to select which
//arithmetic function he/she wants to use, and then they will be prompted to enter only two numbers after
//selecting the arithmetic function. Print the result afterwards, and then after printing
//ask the user if he/she wants toperform another action or not. If yes, repeat the
//program, if not terminate the program.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Loop to allow the user to perform multiple calculations
        while (true)
        {
            Console.WriteLine("Challenge #3 \n");
            // Prompt the user to select an arithmetic operation
            Console.WriteLine("= Select an arithmetic operation =");
            Console.WriteLine("= 1. Addition                    =");
            Console.WriteLine("= 2. Subtraction                 =");
            Console.WriteLine("= 3. Multiplication              =");
            Console.WriteLine("= 4. Division                    =\n");
            Console.Write("Choose your Arithmetic Operation: ");

            // Read the user's choice
            int choice = int.Parse(Console.ReadLine());

            // Prompt the user to enter two numbers
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // Perform the selected arithmetic operation based on the user's choice
            double result = 0;
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Result: {result}\n");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Result: {result}\n");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Result: {result}\n");
                    break;
                case 4:
                    // Check if the second number is not zero to avoid division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {result}\n");
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Cannot Divide by 0\n");
                    }
                    break;
                default:
                    Console.WriteLine("INVALID\n");
                    break;
            }

            // Ask the user if they want to perform another action
            Console.Write("Do you want to do another computation? (yes/no): ");
            string answer = Console.ReadLine().ToLower();

            // If the user's answer is not "yes", exit the loop and terminate the program
            if (answer != "yes")
            {
                break;
            }
        }
    }
}

//4. Write a C# program that takes two numbers as input: the first
//number will be the number to be multiplied and the second
//number will be the multiplier, and prints its multiplication table up
//to the given second number (the multiplier).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Challenge #4 \n");
        Console.Write("Enter a Number: ");
        // Read the input from the user and parse it into an integer
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the Multiplier: ");
        // Read the input from the user and parse it into an integer
        int multiplier = int.Parse(Console.ReadLine());

        // Loop through each multiplier from 1 to the specified multiplier
        for (int i = 1; i <= multiplier; i++)
        {
            // Calculate the product of the number and the current multiplier
            int product = number * i;
            // Print the multiplication table entry for the current multiplier
            Console.WriteLine($"{number} x {i} = {product}");
        }
    }
}

//5. Write a C# program that demonstrates a list that contains 5 cars
//and display a sorted listed after. (Using ArrayList are LinkedList is
//allowed).

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create an ArrayList to store cars
        ArrayList cars = new ArrayList();

        // Add 5 cars to the list
        cars.Add("Mazda RX-7");
        cars.Add("Honda NSX Type-R <3");
        cars.Add("Toyota GR Supra");
        cars.Add("Nissan Skyline GT-R");
        cars.Add("Subaru Impreza 22B");

        // Display the unsorted list of cars
        Console.WriteLine("Challenge #5 \n");
        Console.WriteLine("Unsorted List:");
        foreach (var item in cars)
        {
            Console.WriteLine(item);
        } 

        // Sort the list of cars
        cars.Sort();

        // Display the sorted list of cars
        Console.WriteLine("\nSorted List:");
        foreach (var item in cars)
        {
            Console.WriteLine(item);
        }
    }
}