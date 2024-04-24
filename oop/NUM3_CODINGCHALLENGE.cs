using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            //Menu and to get user's choice
            Console.WriteLine("\nSelect an arithmetic operation:");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            //Get user input
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            //Perform the selected arithmetic operation
            double result = PerformOperation(choice, num1, num2);

            //Display the result
            Console.WriteLine($"The result is: {result}");

            //Ask if the user wants to perform another action
            Console.Write("Do you want to perform another action? (yes/no): ");
            string userInput = Console.ReadLine().ToLower();
            continueProgram = userInput == "yes";
        }

    }

    static double PerformOperation(int choice, double num1, double num2)
    {
        switch (choice)
        {
            case 1:
                return num1 + num2;
            case 2:
                return num1 - num2;
            case 3:
                return num1 * num2;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Error. Cannot divide by zero.");
                    return 0;
                }
                return num1 / num2;
            default:
                Console.WriteLine("Invalid choice.");
                return 0;
        }
    }
}
