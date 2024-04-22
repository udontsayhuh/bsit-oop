using System;

class userInput
{
    static void Main(string[] args)
    {
        int intnum1;
        int intnum2;
        double doublenum1;
        double doublenum2;
        

        Console.Write("Enter a number:");
        intnum1 = int.Parse(Console.ReadLine());

        Console.Write("Enter a number:");
        intnum2 = int.Parse(Console.ReadLine());

        Console.Write("Enter a double:");
        doublenum1 = int.Parse(Console.ReadLine());

        Console.Write("Enter a double:");
        doublenum2 = int.Parse(Console.ReadLine()); 

        int intsum = intnum1 + intnum2;
        Console.WriteLine($"Sum of two integers is: {intsum}");

        double doublesum = doublenum1 + doublenum2; 
        Console.WriteLine($"Sum of two integers is: {doublesum}");

        double product = doublesum * intsum;
        Console.WriteLine($"Product of two sum: {product}");



    }
}