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
                    result = double.Parse(tokens[0]); // Change: Parsing the first token
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
                    case "/": // Change: Added handling for division by zero
                        double divisor;
                        bool parsed = double.TryParse(tokens[i + 1], out divisor);
                        if (!parsed || divisor == 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid non-zero divisor:");
                            input = Console.ReadLine();
                            tokens = input.Split(' ');
                            i = 0; // Change: Reset the loop to reparse the input
                            result = double.Parse(tokens[0]);
                            continue; // Change: Skip the calculation
                        }
                        result /= divisor;
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