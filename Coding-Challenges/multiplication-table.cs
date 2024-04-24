using System;

class Program
{
    static void Main()
    {
        int number = 0;
        int multiplier = 0;
        
        // Get the number to be multiplied and the multiplier from the user
        while (true)
    {
        try
        {   
            Console.Write("Enter the number to be multiplied: ");
            number = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Enter the multiplier (up to which you want the table): ");
            multiplier = Convert.ToInt32(Console.ReadLine());
            break;
        }
        
        catch
        {
            Console.WriteLine("Invalid Input. Integer Only.");
        }
    }
        // Print the multiplication table
        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");
        for (int i = 1; i <= multiplier; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}
