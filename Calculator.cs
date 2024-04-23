using System;

class Calculator
{
    static void Main()
    {
        bool doAnotherCalculation = true;

        while (doAnotherCalculation)
        {
            double result = 0;

            Console.WriteLine("Enter an expression (e.g., 3 + 5 * 2 / 2 =):");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    result = double.Parse(tokens[0]); 
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                    input = Console.ReadLine();
                    tokens = input.Split(' ');
                }
            }

            for (int i = 1; i < tokens.Length - 1; i += 2)
            {
                switch (tokens[i])
                {
                    case "+": // Added case for addition
                        result += double.Parse(tokens[i + 1]);
                        break;
                    case "-": // Added case for subtraction
                        result -= double.Parse(tokens[i + 1]);
                        break;
                    case "*": // Added case for multiplication
                        result *= double.Parse(tokens[i + 1]);
                        break;
                    case "/": // Added case for division
                        double divisor;
                        bool parsed = double.TryParse(tokens[i + 1], out divisor);
                        if (!parsed || divisor == 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid non-zero divisor:");
                            input = Console.ReadLine();
                            tokens = input.Split(' ');
                            i = 0; 
                            result = double.Parse(tokens[0]);
                            continue;
                        }
                        result /= divisor;
                        break;
                    default:
                        Console.WriteLine("Invalid operator."); // Added default case for invalid operator
                        break;
                }
            }

            Console.WriteLine("Result: " + result);

            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                doAnotherCalculation = false;
            }
        }
    }
}