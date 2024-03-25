using System;
class Calculator
{
    public static void PerformCalculator()
    {
        string val;
        Console.WriteLine("--------------------------------");
        Console.WriteLine("         BASIC CALCULATOR       ");
        Console.WriteLine("--------------------------------");
        do
        {
            double result;
            //To enter the first number (Program terminated if invalid)
            double num_1;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num_1))
            {
                Console.WriteLine("Error! Invalid Input!");
                Console.WriteLine("\nTHE PROGRAM IS NOW TERMINATED.");
                return;
            }

            //To display invalid message if the user inputs invalid operator (Program terminated if invalid)
            string op = InputOperator();
            if (op == null)
            {
                Console.WriteLine("\nTHE PROGRAM IS NOW TERMINATED.");
                return;
            }

            //To enter the second number (Program terminated if invalid)
            double num_2;
            Console.WriteLine("\nEnter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out num_2))
            {
                Console.WriteLine("Error! Invalid Input!");
                Console.WriteLine("\nTHE PROGRAM IS NOW TERMINATED.");
                return;
            }

            //To display the result
            result = Calculate(num_1, op, num_2);
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("The result is: " + result);
            Console.WriteLine("--------------------------------");

            //To ask the user if he/she wants to enter two numbers again and calculates it
            Console.WriteLine("\nDo you want to calculate again? (y/n): ");
            val = Console.ReadLine();

        }
        //Valid inputs if the user wants to calculate two numbers again
        while (val == "Y" || val == "y" || val == "YES" || val == "yes" || val == "Yes");
    }

    //To enter operator to calculate the two numbers that set to private string
    private static string InputOperator()
    {
        string op;
        Console.WriteLine("\nEnter any four fundamental operators to calculate: (+, -, *, /): ");
        op = Console.ReadLine();
        if (op != "+" && op != "-" && op != "*" && op != "/")
        {
            Console.WriteLine("Error! Invalid Operator! Program terminated.");
            return null; // Return null that indicates an error
        }
        return op;
    }

    //Calculate set to private
    private static double Calculate(double num_1, string op, double num_2)
    {
        double result = 0;
        // Using switch case statement to calculate the two numbers entered by user
        switch (op)
        {
            case "+": //Addition
                result = num_1 + num_2;
                break;
            case "-": //Subtraction
                result = num_1 - num_2;
                break;
            case "*": //Multiplication
                result = num_1 * num_2;
                break;
            case "/": // Division
                if (num_2 != 0)
                    result = num_1 / num_2;
                else
                    result = 0;
                break;
            default: //(Default) If the user input invalid operator, the program will terminated
                Console.WriteLine("Error! Invalid Operator!");
                Console.WriteLine("\nTHE PROGRAM IS NOW TERMINATED.");
                break;
        }
        return result;
    }

    //Main
    static void Main(string[] args)
    {
        PerformCalculator();
    }
}
