using System;

//A program that will compute the sum of 2 integers and 2 doubles and then multiply their results
class SumProduct
{
    public static void Main(string[] args)
    {   
        //To declare the variable for the sum of two integer numbers
        int resultInt;

        Console.WriteLine("Enter the first integer: "); //integer 1
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer: "); //integer 2
        int num2 = Convert.ToInt32(Console.ReadLine());

        //To add two integers and displays the sum
        resultInt = num1 + num2;
        Console.WriteLine("\nTHE SUM OF TWO INTEGERS IS: " + resultInt);

        //To declare the variable for the sum of two double numbers
        double resultDouble;

        Console.WriteLine("----------------------------------");
        Console.WriteLine("Enter the first double: "); //double 1 
        double num1D = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEnter the second double: "); //double 2
        double num2D = Convert.ToDouble(Console.ReadLine());

        //To add two doubles and displays the sum
        resultDouble = num1D + num2D;
        Console.WriteLine("\nTHE SUM OF TWO DOUBLES IS: " + resultDouble);

        //To declare a variable on getting the product of two sums
        double product;

        //To get the product of two sums and display it in double data type
        product = resultInt * resultDouble;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("THE PRODUCT OF TWO SUMS IS: " + product);

    }
}