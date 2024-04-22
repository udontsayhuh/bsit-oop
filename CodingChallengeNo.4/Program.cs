using System;

class Multiply
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number to be multiplied: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the multiplier: ");
        int nummultiplier = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication table for {num1} up to {nummultiplier}:");
        for (int i = 1; i <= nummultiplier; i++)
        {
            for (int j = 1; j <= num1; j++)
            {
                Console.Write($"{j} x {i} = {j * i}\n");
            }
            Console.WriteLine();
        }
    }
}
