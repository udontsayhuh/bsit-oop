using System;

namespace Calculator_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                do
                {
                    double num1 = 0;
                    double num2 = 0;
                    double result = 0;

                    Console.WriteLine("\n-----------------------------------------------------------------");
                    Console.WriteLine("                         Calculator Program                      ");
                    Console.WriteLine("-----------------------------------------------------------------");

                    //Get the first number
                    Console.Write("\nEnter the first number:  ");
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }

                    //Get second number
                    Console.Write("Enter the second number:  ");
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid input. Please eneter a valid number.");
                    }

                    //Different operators to choose 
                    Console.WriteLine("\nPick an operation. ");
                    Console.WriteLine("\t + : Addition ");
                    Console.WriteLine("\t - : Sbtraction ");
                    Console.WriteLine("\t * : Multiplication ");
                    Console.WriteLine("\t / : Division ");

                    //Asking to choose an operation to do
                    Console.WriteLine("\nThe operation is: ");


                    char mathOperator = ' ';
                    while (mathOperator != '+' && mathOperator != '-' && mathOperator != '*' && mathOperator != '/')
                    {
                        mathOperator = Console.ReadKey().KeyChar;
                        if (mathOperator != '+' && mathOperator != '-' && mathOperator != '*' && mathOperator != '/')
                        {
                            Console.WriteLine("\nInvalid operation. Please enter one of the following: +, -, *, /");
                            Console.WriteLine("\nThe operation is: ");
                        }
                    }

                    //Performing the calculation based on the selected mathematical operator 
                    switch (mathOperator)
                    {
                        case '+':
                            result = num1 + num2;
                            Console.WriteLine($"\nResult: {num1} + {num2} = " + result);
                            break;

                        case '-':
                            result = num1 - num2;
                            Console.WriteLine($"\nResult: {num1} - {num2} = " + result);
                            break;

                        case '*':
                            result = num1 * num2;
                            Console.WriteLine($"\nResult: {num1} * {num2} = " + result);
                            break;

                        case '/':
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine($"\nResult: {num1} / {num2} = " + result);
                            }
                            else
                            {
                                Console.WriteLine("\nDivision by zero (0) is not allowed.");
                            }
                            break;

                        default:
                            Console.WriteLine("\nInvatid operation.");
                            break;
                    }
                    Console.WriteLine("\nDo you want to perform another calculation? (Y/N)");
                } while (Console.ReadKey().Key == ConsoleKey.Y);
            }
        }
    }
}
