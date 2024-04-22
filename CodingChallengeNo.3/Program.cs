using System;

class Artihmetic
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. (+)");
            Console.WriteLine("2. (-)");
            Console.WriteLine("3. (*)");
            Console.WriteLine("4. (/)");

            Console.Write("Select your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double frstnum = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double scndnum = double.Parse(Console.ReadLine());

            double result = choice switch
            {
                1 => frstnum + scndnum,
                2 => frstnum - scndnum,
                3 => frstnum * scndnum,
                4 => frstnum != 0 ? frstnum / scndnum : double.NaN,
                _ => double.NaN
            };

            Console.WriteLine($"Result: {frstnum} {(char)(43 + choice)} {scndnum} = {(double.IsNaN(result) ? "Error: Cannot divide by zero" : result.ToString())}");

            Console.Write("Do you want to perform another action? (yes/no): ");
            repeat = Console.ReadLine().ToLower() == "yes";
        }
    }
}
