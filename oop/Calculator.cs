using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to my Calculator!");
        Console.WriteLine("\n");

        while (true)
        {
            Console.Write("Enter the first number: ");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                break; // Terminate the program if the input is not a valid number
            }

            Console.WriteLine("Select an operator: ( +, -, *, / )");
            Console.Write("Enter your choice: ");
            string operatorChoice = Console.ReadLine();
            double result = 0;

            // Check if the operator choice is not valid
            if (operatorChoice != "+" && operatorChoice != "-" && operatorChoice != "*" && operatorChoice != "/")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Invalid choice! Please enter a valid operator.");
                Console.WriteLine("\n");
                continue; // Restart the loop
            }

            Console.Write("Enter the second number: ");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            // Perform calculation based on operator choice
            switch (operatorChoice)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        continue;
                    }
                    break;
            }
           
            Console.WriteLine("Result: " + result);
            Console.WriteLine("\n");
            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string again = Console.ReadLine();
            if (again.ToLower() != "yes")
                break;
            Console.WriteLine("\n");
        }
    }
}
