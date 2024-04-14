//GHAZI, ZAINA E. BSIT 2-2
//Apply Coding Practices, Optimisation & OOP Concepts to Calculator
//Laboratory #4

using System;

namespace c_sharp_calculator
{

class BaseCalculator //base class for calculator
{
    //encapsulation 
    private double[] numbers;
    private char[] operators;
    protected double result;

    //properties for numbers, operators and operands
    public double[] Numbers
    {
        get { return numbers; }
        set { numbers = value; }
    }

    public char[] Operators
    {
        get { return operators; }
        set { operators = value; }
    }

    //constructor for expression
    public BaseCalculator(double[] numbers, char[] operators)
    {
        Numbers = numbers;
        Operators = operators;
    }

    //Method for performing mathematical calcuations
    public virtual void CalculateResult()
    {
        //setting result to the first number in the array
        result = numbers[0];

        //loop through the array
        for (int index = 0; index < numbers.Length - 1; index++)
        {
            //assign value to the variables
            char operand = operators[index];
            double nextNumber = numbers[index + 1];

            switch (operand)
            {
                case '+':
                    result = (result) + (nextNumber);
                    break;
                case '-':
                    result = (result) - (nextNumber);
                    break;
                case '*':
                    result = (result) * (nextNumber);
                    break;
                case '/':
                    if (nextNumber == 0)
                    {
                        Console.WriteLine("ERROR: Cannot divide by ZERO.");
                        result = 0;
                        break;
                    }
                    else
                    {
                        result = (result) / (nextNumber);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

//inheritance
class Calculate : BaseCalculator
{
    public Calculate(double[] numbers, char[] operators) : base(numbers, operators)
    {
        Numbers = numbers;
        Operators = operators;
    }

    //polymorphism
    public void CalculateResult()
    {
        base.CalculateResult();
        Console.WriteLine("\nResult: " + result);
    }
}


class Calculator  //MAIN CLASS
{
    //declaring empty arrays
    static double[] numbers = new double[0];
    static char[] operators = new char[0];

    static void Main(string[] args)
    {
        //calling function to prompt user imput
        InputNumbers();
    }

    //displaying header with method
    static void Header()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("           CALCULATOR: C# EDITION   ");
        Console.WriteLine("------------------------------------");
    }

    //method for getting numbers and operands through user input
    static void InputNumbers()
    {
        Console.Clear(); //clear the previous display

        //calling header method
        Header();

        while (true)
        {
            try
            {
                Console.Write("Enter a number: ");
                double number = double.Parse(Console.ReadLine());

                //resizing array
                Array.Resize(ref numbers, numbers.Length + 1);
                //adding the number to the array
                numbers[numbers.Length - 1] = number;
                
                //calling the method to ask for operator 
                AskForOperator();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a Number.");
            }
        }
    }
    
    static void AskForOperator()
    {
        //getting operator from user input
        while (true)
        {
            try
            {
                Console.Write("Enter operator (+, -, *, /) OR '=' to calculate the answer: ");
                char operand = char.Parse(Console.ReadLine());
                
                //checks if input is equal
                if (operand == '=')
                {
                    //calls the method to start calculating
                    StartCalculating();
                }
                
                // checks if the operand is valid
                if (ValidateOperator(operand) == true)
                {
                    // resize the array
                    Array.Resize(ref operators, operators.Length + 1);
                    // add the operator to the array
                    operators[operators.Length - 1] = operand;
                    break;
                }
                else 
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid operator! Please enter one of the four operators: +, -, *, /");
            }
        }
               
    }
    
    //method to check if the operator is valid
    static bool ValidateOperator(char operand)
    {
        if (operand == '+' || operand == '-' || operand == '*' || operand == '/')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    //method if user input equal
    static void StartCalculating()
    {
        //checks if numbers and operators array are not empty
        if (numbers.Length >= 2 && operators.Length >= 1)
        {
            Calculate calcu = new Calculate(numbers, operators);
            calcu.CalculateResult();
            
            //calls this method to ask if the user wants to calculate again
            CalculateAgain();
            return;
        }
        else
        {
            Console.WriteLine("Invalid input: Must have at least two numbers and one operator.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // reset the elements inside the array
            Array.Resize(ref numbers, 0);
            Array.Resize(ref operators, 0);
            InputNumbers(); // ask user to input again from the start
            return;
        }
    }

    //method for asking user if they want to calculate again
    static void CalculateAgain()
    {
        while (true)
        {
            Console.Write("\nDo you want to calculate again? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                // reset the elements inside the array
                Array.Resize(ref numbers, 0);
                Array.Resize(ref numbers, 0);
                InputNumbers(); // ask user to input again from the start
                break;
            }
            else if (answer == "n")
            {
                // exits the program
                Console.WriteLine("Exiting program. Thank you for using this Calculator!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input! Must be 'y' or 'n'");
            }
        }
    }
}
