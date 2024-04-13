using System;

namespace Calculator_Program
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            do
            {
                //Clear the screen
                Console.Clear();
                
                //Display program header
                Console.WriteLine("\n          --------------------------------------------------------------------------");
                Console.WriteLine("         |                  ||                                   ||                 |");
                Console.WriteLine("         |                  ||                                   ||                 |");
                Console.WriteLine("         |                  ||         Calculator Program        ||                 |");
                Console.WriteLine("         |                  ||                                   ||                 |");
                Console.WriteLine("         |                  ||                                   ||                 |");
                Console.WriteLine("          --------------------------------------------------------------------------");

                double result = 0;
                double CurrentNum = 0;
                char mathOperator = ' ';
                bool IsFirstNumberInput = true;

                do
                {
                    // Get the operator
                    if (!IsFirstNumberInput)
                    {
                        Console.Write("Enter the operation (+, -, *, /, =): ");
                        while (true)
                        {
                            mathOperator = Console.ReadKey().KeyChar;
                            if (mathOperator != '+' && mathOperator != '-' && mathOperator != '*' && mathOperator != '/' && mathOperator != '=')
                            {
                                Console.WriteLine("\n\nInvalid operation. Please enter one of the following: ");
                                Console.WriteLine("   + (to add)");
                                Console.WriteLine("   - (to subtract)");
                                Console.WriteLine("   * (to multiply)");
                                Console.WriteLine("   / (to divide) ");
                                Console.WriteLine("   = (to get the final result)");
                                Console.Write("\nThe operation is:  ");
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (mathOperator == '=')
                            break;
                    }

                    // Get the number
                    Console.Write("\nEnter a number: ");
                    string input = Console.ReadLine();

                    double num;
                    while (!double.TryParse(input, out num))
                    {
                        Console.WriteLine("\nInvalid input. Please enter a valid number.");
                        Console.Write("Enter a number: ");
                        input = Console.ReadLine();
                    }

                    if (IsFirstNumberInput)
                    {
                        CurrentNum = num;
                        IsFirstNumberInput = false;
                        continue;
                    }
                    else
                    {
                        // Calculate the result based on the previous operator
                        switch (mathOperator)
                        {
                            case '+':
                                result = CurrentNum + num;
                                break;
                            case '-':
                                result = CurrentNum - num;
                                break;
                            case '*':
                                result = CurrentNum * num;
                                break;
                            case '/':
                                if (num != 0)
                                    result = CurrentNum / num;
                                else
                                    Console.WriteLine("\n------Division by zero (0) is not allowed.------");
                                break;
                            default:
                                result = CurrentNum;
                                break;
                        }

                        // Update CurrentNum with the new number
                        CurrentNum = result;
                    }

                }

                while (true);

                //Display final result 
                Console.WriteLine($"\n\nResult: {result}");

                //Ask if the user wants to perform another calculation and starts again from the beginning 
                Console.WriteLine("\nDo you want to perform another calculation? (Y/N)");
                string repeatInput = Console.ReadLine();
                if (repeatInput.ToUpper() != "Y")
                    break;

            }

            while (true);
        }
    }
}

