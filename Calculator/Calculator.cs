//mrccdricmyg

using System;

// abstract class (OOP Concepts application)
public abstract class Calculator
{
    public double get_input()
    {
        return 0;
    }



}

// Inheritance (OOP Concepts application)

public class Power : Calculator
{   public static void turn_off()
    {
        Console.WriteLine("thank you for using the calculator");
        Environment.Exit(0);
    }

    public static void turn_on()
    {
        Console.WriteLine("Initiating Calculator...");
    }
}

// Input class
public class Input : Calculator
{
    // Pass on/off gate
    public static int pass = 1;
    public static bool x = true;

    // Input method of Numerical values
    // Polymorphism (OOP Concepts application)
    public static new double get_input()
    {
        while (true)
        {
            Console.WriteLine("Enter an integer...");
            string input = Console.ReadLine();

            // Attempt to parse the input as a numerical value
            if (!double.TryParse(input, out double result))
            {
                if((pass % 2) != 0)
                {
                    Console.WriteLine("invalid input");
                    Power.turn_off();
                }
                else
                {
                    Console.WriteLine("invalid input, try again");
                }
            }
            else
            {
                pass++;
                double num1 = Convert.ToDouble(input);
                return num1;
            }
        }
    }

    // Input method of Operations
    public static string get_operator()
    {
        while (true)
        {
            Console.WriteLine("Enter an operator (+, -, *, /)...");
            string input = Console.ReadLine();

            switch (input)
            {
                case "+":
                    return "+";
                case "-":
                    return "-";
                case "*":
                    return "*";
                case "/":
                    return "/";
            }
            Console.WriteLine("invalid input");
        }
    }

    // Confirmation Method
    public static void get_confirmation()
        
    {
        while(true){
            Console.WriteLine("Would you like to do another calculation? (y,n) ");
            string input = Console.ReadLine();
            switch (input.ToUpper())
            {

                case "Y":
                    return;
                case "N":
                    Power.turn_off();
                    return;
            }
            Console.WriteLine("invalid input");
            break;
        }


    }
}

// Calculate Class
public class Calculate : Calculator
{
    // to get input from the class methods

    private readonly Input input;

    public static void result()
    {
        double num1 = Input.get_input();
        string operand = Input.get_operator();
        double num2 = Input.get_input();
        switch (operand)
        {
            case "+":
                Console.WriteLine($"{num1} + {num2} = {(num1 + num2)}");
                break;
            case "-":
                Console.WriteLine($"{num1} + {num2} = {(num1 - num2)}");
                break;
            case "*":
                Console.WriteLine($"{num1} + {num2} = {(num1 * num2)}");
                break;
            case "/":
                Console.WriteLine($"{num1} + {num2} = {(num1 / num2)}");
                break;

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Power.turn_on();
        while (true)
        {
            Calculate.result();
            Console.WriteLine("calculation done");
            Input.get_confirmation();
        }

    }
}
