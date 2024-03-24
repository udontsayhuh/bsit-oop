using System;

class Choice
{
    //attributes
    public double num1;
    public double num2;
    public double ans;
    public char option;

    public virtual void Enter() //methods for choosing an option
    {
        Console.WriteLine("\n\t+ : Addition");
        Console.WriteLine("\t- : Subtraction");
        Console.WriteLine("\t* : Multiplication");
        Console.WriteLine("\t/ : Division\n");

        while (true) //loop if the input is incorrect
        {
            Console.Write("Choose an option: ");
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
//inheritance from class Choice

class First : Choice //class for the first input 
{
    public override void Enter() //uses polymorphism
    {
        Console.Write("\nEnter first number: ");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. End of Program.\n");
            Environment.Exit(0); //ends the program
        }
    }
}

class Second : Choice //class for the second input
{
    public override void Enter() //uses polymorphism
    {
        Console.Write("\nEnter second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2)) //if input is non numeric, it will ask the user again to enter
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
            First first = new First(); //instantiate class First
            first.Enter(); //calls the method

            Choice choice = new Choice(); //instantiate class Choice
            choice.Enter();

            Second second = new Second(); //instantiate class Second
            second.Enter();

            switch (choice.option) //will perform the selected option
            {
                case '+': //addition
                    choice.ans = first.num1 + second.num2;
                    Console.WriteLine($"\nUsing addition, the result is {choice.ans}\n");
                    break;

                case '-': //subtraction
                    choice.ans = first.num1 - second.num2;
                    Console.WriteLine($"\nUsing subtraction, the result is {choice.ans}\n");
                    break;

                case '*': //multiplication
                    choice.ans = first.num1 * second.num2;
                    Console.WriteLine($"\nUsing multiplication, the result is {choice.ans}\n");
                    break;

                case '/': //division
                    choice.ans = first.num1 / second.num2;
                    Console.WriteLine($"\nUsing division, the result is {choice.ans}\n");
                    break;

                default: //for invalid operation
                    Console.WriteLine("Invalid option.\n");
                    break;
            }
            Console.Write("Would you like to continue? Press any key to continue and X if not: ");
        }
        while (Console.ReadLine().ToUpper() != "X"); //loops until user ends it

        Console.WriteLine("\nEnd of Program.\n");
    }
}

