// Darben V. Lamonte
// BSIT 2-2

using System;

class BaseCalculator
{
    //implementing encapsulation
    private double[] numbers;
    private char[] operators;
    protected double result;

    // properties
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

    // Constructor
    public BaseCalculator(double[] numbers, char[] operators)
    {
        Numbers = numbers;
        Operators = operators;
    }

    // Method to calculate the result
    public virtual void CalculateResult()
    {
        // set the result to the first number in the array
        result = numbers[0];

        // loop through the array
        for (int index = 0; index < numbers.Length - 1; index++)
        {
            // assign value to the variables to start calculating
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
                        Console.WriteLine("Undefined. Cannot divide by zero");
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

// implementing inheritance
class Calculate : BaseCalculator
{
    public Calculate(double[] numbers, char[] operators) : base(numbers, operators)
    {
        Numbers = numbers;
        Operators = operators;
    }

    // implementing polymorphism
    public void CalculateResult()
    {
        base.CalculateResult();
        Console.WriteLine("\nResult: " + result);
    }
}


class Calculator
{
    // declaring empty arrays
    static double[] numbers = new double[0];
    static char[] operators = new char[0];

    static void Main(string[] args)
    {
        // calls the InputNumbers() method to start asking for input
        InputNumbers();
    }

    // method to display header
    static void Header()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("           Basic Calculator         ");
        Console.WriteLine("------------------------------------");
    }

    // method to get the user input for numbers and operand
    static void InputNumbers()
    {
        Console.Clear(); // clear the previous display

        // calls header method
        Header();

        while (true)
        {
            try
            {
                Console.Write("Enter a number: ");
                double number = double.Parse(Console.ReadLine());

                // resize the array
                Array.Resize(ref numbers, numbers.Length + 1);
                // add the number to the array
                numbers[numbers.Length - 1] = number;
                
                // calls the method to ask for operator 
                AskForOperator();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Must be a numeric value");
            }
        }
    }
    
    // a method to ask operator
    static void AskForOperator()
    {
        // get the operator from user input
        while (true)
        {
            try
            {
                Console.Write("Enter an operator (or = to calculate): ");
                char operand = char.Parse(Console.ReadLine());
                
                // checks if input is equal
                if (operand == '=')
                {
                    // calls the method to start calculating
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
                Console.WriteLine("Invalid input! Please enter +, -, *, or /");
            }
        }
               
    }
    
    // a method to check if the operator is valid
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
    
    // method if user input equal
    static void StartCalculating()
    {
        // checks if numbers and operators array are not empty
        if (numbers.Length >= 2 && operators.Length >= 1)
        {
            Calculate calcu = new Calculate(numbers, operators);
            calcu.CalculateResult();
            
            // calls the CalculateAgain() method to ask if the user want to do another calculation
            CalculateAgain();
            return;
        }
        else
        {
            Console.WriteLine("Invalid input! Must have at least two numbers and one operator");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // reset the elements inside the array
            Array.Resize(ref numbers, 0);
            Array.Resize(ref operators, 0);
            InputNumbers(); // ask user to input again from the start
            return;
        }
    }

    // a method that asks user if they want to do another calculation
    static void CalculateAgain()
    {
        while (true)
        {
            Console.Write("\nDo you want to do another calculation? (y/n): ");
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
                Console.WriteLine("Exiting program...");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input! Must be 'y' or 'n'");
            }
        }
    }
}
