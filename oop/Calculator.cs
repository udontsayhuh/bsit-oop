using System;

// Abstract class Option
// abstract base class that represents an option in the calculator program
abstract class Option
{
    // fields that will store the num1 and num2, result, and operation
    // Encapsulated variables
    public double num1;
    public double num2;
    public double result;
    public string operation;

    // a subclass that will execute an abstract method
    public abstract void Enter();
}

// FirstNum subclass inheriting from Option
class FirstNum : Option // a class that will enter a first number 
{
    public override void Enter()
    {
        try
        {
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
        }

        catch (Exception)
        {
            Console.WriteLine("Invalid input! End of Calculator Program.\n"); // handle the invalid input and terminates the program
            Environment.Exit(0);
        }
        }
    }

// OperatorInput subclass inheriting from Option
class OperatorInput : Option  // a class that will choose/enter an operator
{
        // Enter() method
        public override void Enter()
        {
            Console.WriteLine("Options: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide\n");

            while (true)
            {
                Console.WriteLine("Enter an operator you would like: ");
                operation = Convert.ToString(Console.ReadLine());
                
                // check if the operator chose/enterned is valid
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operator! Please choose again.\n"); // handle the invalid input that the user will still choose a valid operator
                }
            }



        }
    }

// SecondNum subclass inheriting from Option
class SecondNum : Option // a class that will enter a second number
{
        // Enter() method
        public override void Enter()   
        {

        while (true)
        {
            Console.Write("Enter second number: ");
            string input = Console.ReadLine();
            try
            {
                num2 = Convert.ToDouble(input);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please input a valid number.\n"); // handle the invalid input and will still input a valid numerical value
            }
        }
        }
}

// main program class
class Program
    {
        static void Main(string[] args)
        {
            // creating objects of subclasses
            FirstNum first = new FirstNum();
            OperatorInput second = new OperatorInput();
            SecondNum third = new SecondNum();
            
            // main loop for calculator program
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Welcome to Calculator Program!");
                Console.WriteLine("------------------------------");

            // an interface to call Enter() method polymorphism
            // input process for each part of the operation
                first.Enter();
                second.Enter();
                third.Enter();

            // perform the selected operation and display the results
                switch (second.operation)
                {
                    case "+":
                        second.result = first.num1 + third.num2;
                        Console.WriteLine($"Result in Addition: {second.result}\n");
                        break;

                    case "-":
                        second.result = first.num1 - third.num2;
                        Console.WriteLine($"Result in Subtraction: {second.result}\n");
                        break;

                    case "*":
                        second.result = first.num1 * third.num2;
                        Console.WriteLine($"Result in Multiplication: {second.result}\n");
                        break;

                    case "/":
                        if (third.num2 != 0)
                        {
                            second.result = first.num1 / third.num2;
                            Console.WriteLine($"Result in Division: {second.result}\n");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Operator!");
                        break;
                }
                
                // check if the user wants to continue using this calculator program
                Console.WriteLine("Would you like to continue? Y/N: ");
            } while (Console.ReadLine().ToUpper() == "Y");
           
            // end of program
            Console.WriteLine("Thank You for using this Calculator!");

        }
}
