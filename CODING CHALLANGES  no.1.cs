using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Adding Integers");
        
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        int sumInt = num1 + num2; 
        
        Console.WriteLine("The sum of " + num1 + " + " + num2 + " is: " + sumInt);
        
        Console.WriteLine("\nAdding Doubles");
        
        Console.WriteLine("Enter the first double:");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second double:");
        double num4 = Convert.ToDouble(Console.ReadLine());

        double sumDouble = num3 + num4; 

        Console.WriteLine("The sum of " + num3 + " + " + num4 + " is: " + sumDouble);
        
        double product = (double)sumInt * sumDouble; // Cast sumInt to double before multiplication
        Console.WriteLine("\nThe product of " + sumInt + " + " + sumDouble + " is: " + product);
    }
}
