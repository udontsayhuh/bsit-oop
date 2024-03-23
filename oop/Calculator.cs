using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Calculator
    {
        static void Main(string[] args)
        {
            bool will_try_again = true;
            while (will_try_again)
            {
                Console.Clear();

                //Call input functions
                double num_1 = InputNum();
                char operation = InputOperator();
                double num_2 = InputNum();

                //Call calculate function and displays result
                double result = Calculate(num_1, operation, num_2);
                Console.WriteLine($"\n{num_1} {operation} {num_2} = {result}\n");

                //Prompts user to input Y or N, will not terminate unless Y or N
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Try Again? (Y/N): ");
                        string yes_no = Console.ReadLine().ToUpper();
                        if (yes_no == "Y")
                            break;
                        else if (yes_no == "N")
                        {
                            will_try_again = false;
                            break;
                        }
                        else
                            Console.WriteLine("Y or N only!");
                    }
                    catch
                    {
                        Console.WriteLine("Y or N only!");
                    }
                }
            }
        }

        static double InputNum() //Terminates program if input is not double
        {
            try
            {
                Console.Write("Enter number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine("INVALID INPUT: " + ex.Message);
                Environment.Exit(1);
                return 0;
            }
        }

        static char InputOperator() //Terminates program if input is not valid operator
        {
            try
            {
                Console.Write("Enter Operator ( + , - , / , *): ");
                char operation = Convert.ToChar(Console.ReadLine());
                if (operation == '+' || operation == '-' || operation == '/' || operation == '*')
                    return operation;
                else
                {
                    Console.WriteLine("Invalid Operator");
                    Environment.Exit(1);
                    return '0';
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("INVALID INPUT: " + ex.Message);
                Environment.Exit(1);
                return '0';
            }
        }

        static double Calculate(double num_1, char operation, double num_2) //Calculates result
        {
            switch (operation)
            {
                case '+':
                    return num_1 + num_2;
                    break;
                case '-':
                    return num_1 - num_2;
                    break;
                case '/':
                    return num_1 / num_2;
                    break;
                case '*':
                    return num_1 * num_2;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
