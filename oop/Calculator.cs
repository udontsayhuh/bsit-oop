using System;

class ChoosingOperator
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

class FirstElement : ChoosingOperator //class for the first input 
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

class AnotherElement : ChoosingOperator //class for the second input
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
            FirstElement firstelemet = new FirstElement(); //instantiate class First
            ChoosingOperator choosingoperator = new ChoosingOperator(); //instantiate class Choice
            AnotherElement anotherelement = new AnotherElement(); //instantiate class Second

            choosingoperator.count = 1;

            while (true)
            {

                if (choosingoperator.count == 1) //if condition is correct
                {
                    firstelemet.Enter(); //calls the method (First Class)
                }
                else //if count is not equal to 1
                {
                    firstelemet.num1 = choosingoperator.ans; //store the answer to the variable num1
                }

                choosingoperator.Enter(); //calls the method (Enter Class)

                if (choosingoperator.option == '=') //if operator is =, then it prints the result
                {
                    Console.WriteLine($"\n The final result is {choosingoperator.ans}\n");
                    break;
                }

                anotherelement.Enter(); //calls the method (Second Class)


                switch (choosingoperator.option) //will perform the selected option
                {
                    case '+': //addition
                        choosingoperator.ans = firstelemet.num1 + anotherelement.num2;
                        choosingoperator.count = 2;
                        break;

                    case '-': //subtraction
                        choosingoperator.ans = firstelemet.num1 - anotherelement.num2;
                        choosingoperator.count = 2;
                        break;

                    case '*': //multiplication
                        choosingoperator.ans = firstelemet.num1 * anotherelement.num2;
                        choosingoperator.count = 2;
                        break;

                    case '/': //division
                        choosingoperator.ans = firstelemet.num1 / anotherelement.num2;
                        choosingoperator.count = 2;
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
