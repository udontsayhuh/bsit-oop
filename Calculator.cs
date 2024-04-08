//GHAZI, ZAINA E. BSIT 2-2
//Modify Calculator
//Laboratory #3

using System;

namespace c_sharp_calculator
{
    //separate class for exception handling (division by zero)
public class DivisionByZeroException : Exception
{
    public DivisionByZeroException(string message) : base(message)
    {
    }
}
//base class
public class Calculator
{
    //method for performing calculations using operators and operands
    protected virtual double Calculate(double Num1, double Num2, char Symbol)
    {
        switch (Symbol)
        {
            case '+':
                return Num1 + Num2;
            case '-':
                return Num1 - Num2;
            case '*':
                return Num1 * Num2;
            case '/':
                if (Num2 == 0)
                {
                    throw new DivisionByZeroException("ERROR: Cannot divide by Zero!");
                }
                return firstNumber / secondNumber;
            default:
                throw new InvalidOperationException("Invalid Operator! Please enter one of the four Operators: +, -, *, /");
        }
    }
}

//subclass for mathematical expression
public class Expression : Calculator
{
    //properties for storing expression components
    public double num1 { get; set; }
    public char symbol { get; set; }

    // Constructor to initialize the expression components
    public Expression(double Num1, char Symbol)
    {
        num1 = Num1;
        symbol = Symbol;
    }

    //method for evaluating expressions using Calculator's Calculate method
    public double Evaluate(double Num2)
    {
        try
        {
            return Calculate(Num1, Num2, Symbol);
        }
        catch (DivisionByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            throw; //rethrow the exception to be caught in the Main method
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return double.NaN;
        }
    }
}

//MAIN CLASS
class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            double result = 0;
            double NUm = 0;
            char operatorSymbol = ' ';
            bool isFirstIteration = true;

            Console.Clear(); // Clear the console screen
            Console.WriteLine("=====================================================");
            Console.WriteLine("                 CALCULATOR: C# EDITION");
            Console.WriteLine("=====================================================");

            while (true)
            {
                //input 1st num
                if (isFirstIteration)
                {
                    Console.Write("Enter a Number: ");
                    if (!double.TryParse(Console.ReadLine(), out Num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a Number.");
                        continue;
                    }
                    isFirstIteration = false;
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Enter operator (+, -, *, /) OR '=' to calculate the answer: ");
                        char.TryParse(Console.ReadLine(), out Symbol);

                        if (Symbol == '=')
                            break;

                        if (Symbol != '+' && Symbol != '-' && Symbol != '*' && Symbol != '/')
                        {
                            Console.WriteLine("Invalid operator! Please enter one of the four operators: +, -, *, /");
                            continue;
                        }

                        break;
                    }

                    if (Symbol == '=')
                    {
                        result = Num1;
                        break;
                    }

                    double Num2;
                    while (true)
                    {
                        Console.Write("Enter a Number: ");
                        string input = Console.ReadLine();

                        if (!double.TryParse(input, out Num2))
                        {
                            Console.WriteLine("Invalid input! Please enter a Number.");
                            continue;
                        }

                        break;
                    }

                    Expression expression = new Expression(Num1, Symbol);
                    try
                    {
                        result = expression.Evaluate(Num2);
                    }
                    catch (DivisionByZeroException)
                    {
                        //calculation must reset once there exists division by zero
                        Console.WriteLine("Resetting calculation due to Division by Zero.\nPress any key to continue...");
                        Console.ReadLine(); //before clearing the screen for a reset
                        isFirstIteration = true;
                        break;
                    }

                    Num1 = result;
                }
            }

            if (isFirstIteration) //continue to the next iteration (if calculation has been reset)
                continue;

            Console.WriteLine($"Final result: {Math.Round(result, 2)} "); //Result becomes rounded to 2 decimal places

            //Ask user if they wish to try the Calculator again
            Console.Write("\nWould you like to calculate again?\n(Y or y if yes): ");
            string choice2 = Console.ReadLine().ToUpper();
            if (choice2 != "Y")
            {
                Console.WriteLine("\Terminating program.\nThank you for using this Calculator! :D");
                break;
            }
        }
    }
}
}
