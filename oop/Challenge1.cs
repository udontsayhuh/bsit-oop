using System;

class Variables
{
    public int integer1, integer2, integer_ans;
    public double double1, double2, double_ans, final_ans;

    public virtual void Addition()
    {
        Console.Write("\n\tP R O B L E M  # 1\n\n");
    }

}

class Computing_Integer : Variables
{
    public override void Addition()
    {
        Console.Write("\nI N T E G E R\n");

        Console.Write("\nEnter first integer number: ");
        while (!int.TryParse(Console.ReadLine(), out integer1)) //loops until valid numeral value is entered 
        {
            Console.WriteLine("Invalid input. Only an integer value is accepted.\n");
            Console.Write("Enter first integer number: ");
        }

        Console.Write("\nEnter second integer number: ");
        while (!int.TryParse(Console.ReadLine(), out integer2)) //loops until valid numeral value is entered 
        {
            Console.WriteLine("Invalid input. Only an integer value is accepted.\n");
            Console.Write("Enter second integer number: ");
        }

        integer_ans = integer1 + integer2;
        Console.WriteLine($"\nInteger Addition: {integer1} + {integer2} = {integer_ans}");
    }
}

class Computing_Double : Variables
{
    public override void Addition()
    {
        Console.Write("\n\nD O U B L E\n");

        Console.Write("\nEnter first double number: ");
        while (!double.TryParse(Console.ReadLine(), out double1)) //loops until valid numeral value is entered 
        {
            Console.WriteLine("Invalid input. Only a double value is accepted.\n");
            Console.Write("Enter first double number: ");
        }

        Console.Write("\nEnter second double number: ");
        while (!double.TryParse(Console.ReadLine(), out double2)) //loops until valid numeral value is entered 
        {
            Console.WriteLine("Invalid input. Only a double value is accepted.\n");
            Console.Write("Enter second double number: ");
        }

        double_ans = double1 + double2;
        Console.WriteLine($"\nDouble Addition: {double1} + {double2} = {double_ans}");
    }
}

class Final_Computation : Variables
{
    public override void Addition()
    {
        Console.Write("\n\nF I N A L  A N S W E R\n");

        final_ans = integer_ans + double_ans;

        Console.WriteLine($"\n{integer_ans} + {double_ans} = {final_ans}\n\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Variables variables = new Variables();
        variables.Addition();

        Computing_Integer computing_integer = new Computing_Integer();
        computing_integer.Addition();

        Computing_Double computing_double = new Computing_Double();
        computing_double.Addition();

        Final_Computation final_computation = new Final_Computation();
        final_computation.integer_ans = computing_integer.integer_ans;
        final_computation.double_ans = computing_double.double_ans;
        final_computation.Addition();
    }

}