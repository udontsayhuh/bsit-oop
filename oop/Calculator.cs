using System;

namespace Calculator
{
    // option class represents a calculator operation
    public class CalculatorOption
    {
        // fields that store the nums, results, and operation
        public double num1 = 0;
        public double num2 = 0;
        public double result = 0;
        public string operation = "";

        //method to get a valid number from the user 
        //encapsulation
        public double GetValue()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number only.");
                }
            }
        }

        //method to display and get the valid operator options from the user
        //encapsulation
        public void GetOperation()
        {
            do
            {
                Console.WriteLine("Operators: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("\t= : Result");
                operation = Convert.ToString(Console.ReadLine());

                if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "=")
                {
                    Console.WriteLine("Invalid Operator! Please choose again.");
                }
            } while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "=");
        }

        //method to calculate the result based on the selected operation
        //abstraction
        public void CalculateResult()
        {
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                case "=":
                    break;
                default:
                    Console.WriteLine("Invalid Operator!");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            string continueOption;
            bool runAgain;
            do
            {
                CalculatorOption userOption = new CalculatorOption();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Welcome to Calculator Program!");
                Console.WriteLine("------------------------------");
                userOption.num1 = userOption.GetValue();   //get the first number
                do
                {
                    userOption.GetOperation(); //get the operation
                    if (userOption.operation != "=")
                    {
                        userOption.num2 = userOption.GetValue(); //get the second num
                        userOption.CalculateResult(); //calculate the result
                        userOption.num1 = userOption.result; //store the result for next operation
                        
                    }
                } while (userOption.operation != "="); //repeat until the user selecs the "=" operator
                Console.WriteLine($"Result: {userOption.result}");

                Console.Write("\nWould you like to continue? Y/N: ");
                continueOption = Convert.ToString(Console.ReadLine());
                continueOption = continueOption.ToUpper();

                runAgain = continueOption == "Y";

            } while (runAgain); //repeat the whole process if the user wants to continue

            Console.WriteLine("Thank You for using this Calculator!"); //end of program
        }
    }
}
