using System;

class Choice
{
    public double num1;
    public double num2;
    public double ans;
    public char option;
    public int count = 1;

    public virtual void Enter()
    {
        Console.WriteLine("\n\tEnter + for Addition");
        Console.WriteLine("\tEnter - for Subtraction");
        Console.WriteLine("\tEnter * for Multiplication");
        Console.WriteLine("\tEnter / for Division");
        Console.WriteLine("\tEnter = for Total Result \n");

        while (true)
        {
            Console.Write("Enter operator: ");
            option = Convert.ToChar(Console.ReadLine());

            if (option == '+' || option == '-' || option == '*' || option == '/' || option == '=')
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid. \n");
            }
        }
    }
}


class First : Choice
{
    public override void Enter()
    {
        Console.Write("\nEnter value: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input.\n");
            Console.Write("Enter value: ");
        }
    }
}

class Second : Choice
{
    public override void Enter()
    {
        Console.Write("\nEnter value: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input.\n");
            Console.Write("Enter value: ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("WELCOME TO MY CALCULATOR PROGRAM");
        Console.WriteLine("-------------------------------------");

        do
        {
            First first = new First();
            Choice choice = new Choice();
            Second second = new Second();

            choice.count = 1;

            while (true)
            {

                if (choice.count == 1)
                {
                    first.Enter();
                }
                else
                {
                    first.num1 = choice.ans;
                }

                choice.Enter();

                if (choice.option == '=')
                {
                    Console.WriteLine($"\n Total Result: {choice.ans}\n");
                    break;
                }

                second.Enter();

                switch (choice.option)
                {
                    case '+':
                        choice.ans = first.num1 + second.num2;
                        choice.count = 2;
                        break;

                    case '-':
                        choice.ans = first.num1 - second.num2;
                        choice.count = 2;
                        break;

                    case '*':
                        choice.ans = first.num1 * second.num2;
                        choice.count = 2;
                        break;

                    case '/':
                        choice.ans = first.num1 / second.num2;
                        choice.count = 2;
                        break;

                    default:
                        Console.WriteLine("Invalid.\n");
                        break;
                }
            }
            Console.Write("Continue? Yes = any key. No = N");
        }
        while (Console.ReadLine().ToUpper() != "N");

        Console.WriteLine("\nThat's my Calculator Program!\n");
    }
}
