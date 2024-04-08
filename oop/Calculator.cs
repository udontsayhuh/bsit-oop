using System;

class Choice
{
    //attributes
    public double num1;
    public double num2;
    public double ans;
    public char option;
    public int count = 1;

    public virtual void Enter() //methods for choosing an option
    {
        Console.WriteLine("\n\t+ : Addition");
        Console.WriteLine("\t- : Subtraction");
        Console.WriteLine("\t* : Multiplication");
        Console.WriteLine("\t/ : Division");
        Console.WriteLine("\t= : Equal\n");

        while (true) //loop if the input is incorrect
        {
            Console.Write("Choose an option: ");
            option = Convert.ToChar(Console.ReadLine());

            if (option == '+' || option == '-' || option == '*' || option == '/' || option == '=')
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
        while (!double.TryParse(Console.ReadLine(), out num1)) //loops until valid numeral value is entered 
        {
            Console.WriteLine("Invalid input. Only numerical value is accepted.\n");
            Console.Write("Enter first number: ");
        }
    }
}

class Second : Choice //class for the second input
{
    public override void Enter() //uses polymorphism
    {
        Console.Write("\nEnter a number: ");
        while (!double.TryParse(Console.ReadLine(), out num2)) //loops until valid numeral value is entered
        {
            Console.WriteLine("Invalid input. Only numerical value is accepted.\n");
            Console.Write("Enter a number: ");
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
            Choice choice = new Choice(); //instantiate class Choice
            Second second = new Second(); //instantiate class Second

            choice.count = 1;

            while (true)
            {

                if (choice.count == 1) //if user will enter the first number
                {
                    first.Enter(); //calls the method (First Class)
                }
                else //if user will enter another number
                {
                    first.num1 = choice.ans; //store the answer to the variable num1
                }

                choice.Enter(); //calls the method (Enter Class)

                if (choice.option == '=') //if operator is =, then it prints the result
                {
                    Console.WriteLine($"\n The final result is {choice.ans}\n");
                    break;
                }

                second.Enter(); //calls the method (Second Class)


                switch (choice.option) //will perform the selected option
                {
                    case '+': //addition
                        choice.ans = first.num1 + second.num2;
                        choice.count = 2;
                        break;

                    case '-': //subtraction
                        choice.ans = first.num1 - second.num2;
                        choice.count = 2;
                        break;

                    case '*': //multiplication
                        choice.ans = first.num1 * second.num2;
                        choice.count = 2;
                        break;

                    case '/': //division
                        choice.ans = first.num1 / second.num2;
                        choice.count = 2;
                        break;

                    default: //for invalid operation
                        Console.WriteLine("Invalid option.\n");
                        break;
                }
            }
            Console.Write("Would you like to continue? Press any key to continue and X if not: ");
        }
        while (Console.ReadLine().ToUpper() != "X"); //loops until user ends it

        Console.WriteLine("\nEnd of Program.\n");
    }
}
