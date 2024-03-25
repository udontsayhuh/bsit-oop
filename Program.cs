using System;

class Calculator
{
    static void Main()
    {
        bool tryagain = true;

        while (tryagain)
        {
            Console.WriteLine("Calculator\n");

            double num1, num2;
            char numerator;

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid numerical value.");
                return;
            }

            Console.Write("Enter the operator: ");
            numerator = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input.");
                return;
            }

            double result = 0;

            switch (numerator)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    return;
            }

            Console.WriteLine($"Result: {num1} {numerator} {num2} = {result}");

            Console.WriteLine("Do you want to use the calculator again? (Y/N)");
            string choice = Console.ReadLine();

            if (choice.ToUpper() != "Y")
            {
                tryagain = false;
            }

            Console.Clear(); 
        }
    }
}
