// Optimized Code
//continuous calcu

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
        Console.WriteLine("Welcome to Calculator, to use, first enter a valid integer followed by an operator (+, -, *, /)");
        Console.WriteLine("To Complete the calculation enter (=)");
    }
}

// Input class
public class Input : Calculator

    
{
    public static int pass = 0;
    // ** updated for repeat invalid input and not terminate program.

    // Input method of Numerical values
    // Polymorphism (OOP Concepts application)
    public static new double get_input()
    {
        while (true)
        {
            string input = Console.ReadLine();

            // Attempt to parse the input as a numerical value
            if (!double.TryParse(input, out double result))
            {
                Console.WriteLine("Invalid Input, Enter Valid Integer. ");
            }
            else
            {
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
            string input = Console.ReadLine();

            switch (input)
            {
                case "+":
                    pass++;
                    return "+";
                case "-":
                    pass++;
                    return "-";
                case "*":
                    pass++;
                    return "*";
                    
                case "/":
                    pass++;
                    return "/";

                // New case operator =
                case "=":
                    return "=";
            }
            Console.WriteLine("invalid input, enter valid operator");
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
                    Console.Clear();
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
    //cumulative value
    public static double total = 0;
    public static bool init = false;

    // to get input from the class methods

    public static bool result()
    {
        double num = 0;
        double num1;

        // condition to take initial input from user

        if (init == false)
        {
            num1 = Input.get_input();
        }
        else
        {
            num1 = total;
        }

        string operand = Input.get_operator();

        if (operand == "=")

        // condition to stop continuous addition

        {
            Console.WriteLine($"= {num1}");
            total = 0;
            init = false;
            return true;
        }

        double num2;

        // Removes Division by zero

        while (true)
        {
            num2 = Input.get_input();
            if (operand == "/"  && num2 == 0 )
            {
                Console.WriteLine("invalid input");
            }
            else
            {
                break;
            }
        }
        init = true;
        switch (operand)
        {
            case "+":
                num = num1 + num2;
                total = num;
                break;
            case "-":
                num = num1 - num2;
                total = num;
                break;
            case "*":
                num = num1 * num2;
                total = num;
                break;
            case "/":
                num = num1 / num2;
                total = num;
                break;
        }
        return false;
    }

}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Power.turn_on();

            // looping calculation

            while(true) { 
                bool status = Calculate.result(); 
                if(status == true)
                {
                    break;
                }
            }
            Input.get_confirmation();
        }

    }
}
