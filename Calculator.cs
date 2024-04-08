//REGINE MAE G. HAMBIOL
//BSIT2-2
using System;

namespace Calculator
{
    // Base class for calculator functionality
    class Calculator
    {
        //encapsulation, Fields are declared as private to restrict direct access from outside the class
        private double result;

        //abstraction, Protected modifier allows derived classes to access this method which are numbers and operator
        protected double Calculate(double num1, double num2, double result, char op)
        { //polymorphism, switch statement operation
            switch (op)
            {
                case '+':
                    return result + num1;
                case '-':
                    return result - num1;
                case '*':
                    return result * num1;
                case '/':
                    if (num1 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero. Please enter a number or operator");
                        return result;
                    }
                    return result / num1;
                default:
                    return result;
            }
        }

        //abstraction, Protected modifier allows derived classes to access this method
        protected bool IsOperator(string input)
        {
            return input == "+" || input == "-" || input == "*" || input == "/";
        }

        //abstraction, Public method to perform calculation and display result
        public void PerformCalculation()
        {
            string userInput = "";

            Console.WriteLine("-----------------------");
            Console.WriteLine(" Calculator Activity");
            Console.WriteLine("-----------------------");

            do
            {
                Console.Write("Enter number or operator (Enter '=' to see the result): ");
                string input = Console.ReadLine();

                if (input == "=")
                {
                    break;
                }
                //encapsulation, convert string to double and checks valid parameter
                if (double.TryParse(input, out double number))
                {
                    if (userInput == "")
                        result = number;
                    else
                    {
                        if (!IsOperator(userInput))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid operator.");
                            continue;
                        }  //anstraction, update number and operator used...
                        result = Calculate(number, result, result, userInput[0]);
                    }
                }
                else if (IsOperator(input))
                {
                    userInput = input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or operator.");
                    continue;
                }

            } while (true);

            PrintResult();
        }

        // Public method to print the result
        public void PrintResult()
        {
            Console.WriteLine($"Result: {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        { //polymorphism, create New instance...
            //abstraction, calling the method used to start the program...
            do
            {
                Calculator calculator = new Calculator();
                calculator.PerformCalculation();

                Console.Write("Do you want to continue? (YES/NO): ");
                string continueInput = Console.ReadLine();

                if (continueInput.ToUpper() != "YES")
                    break;

            } while (true);
            //choice NO display 
            Console.WriteLine("Thank you for using the calculator!!!");
            Console.ReadKey();
        }
    }
}
