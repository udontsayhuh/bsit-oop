using System;

class Variables
{
    public double num1, num2, ans;
    public char option;

    public virtual void Calculator()
    {
        Console.WriteLine("\t\tC A L C U L A T O R\n");
    }
}

class Operator : Variables
{
    public override void Calculator()
    {
        Console.WriteLine("\n\t+ : Addition");
        Console.WriteLine("\t- : Subtraction");
        Console.WriteLine("\t* : Multiplication");
        Console.WriteLine("\t/ : Division\n");

        while (true) //loop if the input is incorrect
        {
            Console.Write("Choose an operator: ");
            option = Convert.ToChar(Console.ReadLine());

            if (option == '+' || option == '-' || option == '*' || option == '/')
            {
                break; //breaks the loop if input is correct
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose again.\n");
            }
        }
    }
}

class Value : Variables
{
    public override void Calculator()
    {
        Console.Write("\nEnter first number: ");
        while (!double.TryParse(Console.ReadLine(), out num1)) //loops until valid numeral value is entered 
        {
            Console.WriteLine("Invalid input. Only numerical value is accepted.\n");
            Console.Write("Enter first number: ");
        }

        Console.Write("\nEnter second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2)) //loops until valid numeral value is entered 
        {
            Console.WriteLine("Invalid input. Only numerical value is accepted.\n");
            Console.Write("Enter second number: ");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        do //uses do-while loop
        {
            Variables variables = new Variables(); //initialize the class
            Operator myoperator = new Operator();
            Value value = new Value();

            variables.Calculator(); //calls the method
            myoperator.Calculator();
            value.Calculator();

            switch (myoperator.option) //do switch case to do the calculation
            {
                case '+':
                    variables.ans = value.num1 + value.num2;
                    Console.WriteLine($"Result: {variables.ans}");
                    break;

                case '-':
                    variables.ans = value.num1 - value.num2;
                    Console.WriteLine($"Result: {variables.ans}");
                    break;

                case '*':
                    variables.ans = value.num1 * value.num2;
                    Console.WriteLine($"Result: {variables.ans}");
                    break;

                case '/':
                    if (value.num2 != 0)
                    {
                        variables.ans = value.num1 / value.num2;
                        Console.WriteLine($"Result: {variables.ans}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid\n");
                    break;
            }
            Console.Write("\nWould you like to continue? Press any key to continue and X if not: "); //ask user if wants to use again
        }
        while (Console.ReadLine().ToUpper() != "X"); //loops until user ends it

        Console.WriteLine("\nEnd of Program.\n"); //ends the program is user wants to end it
    }
}