using System;

namespace Calculator_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("\n-----------------------------------------------------------------");
                Console.WriteLine("                         Calculator Program                      ");
                Console.WriteLine("-----------------------------------------------------------------");

                double result = 0;
                double currentNum = 0;
                char mathOperator = ' ';
                bool isFirstInput = true;

                do
                {
                    // Get the operator
                    if (!isFirstInput)
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

                    if (isFirstInput)
                    {
                        currentNum = num;
                        isFirstInput = false;
                        continue;
                    }
                    else
                    {
                        // Calculate the result based on the previous operator
                        switch (mathOperator)
                        {
                            case '+':
                                result = currentNum + num;
                                break;
                            case '-':
                                result = currentNum - num;
                                break;
                            case '*':
                                result = currentNum * num;
                                break;
                            case '/':
                                if (num != 0)
                                    result = currentNum / num;
                                else
                                    Console.WriteLine("\n------Division by zero (0) is not allowed.------");
                                break;
                            default:
                                result = currentNum;
                                break;
                        }

                        // Update currentNum with the new number
                        currentNum = result;
                    }

                } while (true);

                Console.WriteLine($"\n\nResult: {result}");

                Console.WriteLine("\nDo you want to perform another calculation? (Y/N)");
                string repeatInput = Console.ReadLine();
                if (repeatInput.ToUpper() != "Y")
                    break;

            } while (true);
        }
    }
}
