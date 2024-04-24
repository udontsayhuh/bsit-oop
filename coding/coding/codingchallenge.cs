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
    //
   
}
