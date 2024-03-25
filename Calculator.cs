// Miyuki Mharie C. Parocha
// BSIT 2-2

using System;

abstract class Calculation
{ // creating a class that will store the abtract methods add(), subtract(), multiply(), divide()
    public abstract double add(double num1, double num2);
    public abstract double subtract(double num1, double num2);
    public abstract double multiply(double num1, double num2);
    public abstract double divide(double num1, double num2);
}

class Calculator : Calculation // inherits the methods inside the calculation
{
    private double num1, num2;
    private string operation;

    public void getNum1(double num)
    {
        num1 = num;
    }
    public void getNum2(double num)
    {
        num2 = num;
    }
    public void getOperation(string operation)
    {
        this.operation = operation;
    }
    public override double add(double num1, double num2) //override the method add, also applying Polymorphism
    { // creating a method add, with 2 parameters (double num1, double num2)
        return num1 + num2; // return the computation to the main class
    }
    public override double subtract(double num1, double num2) //override the method subtract, also applying Polymorphism
    { // creating a method subtract, with 2 parameters (double num1, double num2)
        return num1 - num2; // return the computation to the main class
    }
    public override double multiply(double num1, double num2) //override the method multiply, also applying Polymorphism
    { // creating a method multiply, with 2 parameters (double num1, double num2)
        return num1 * num2; // return the computation to the main class
    }
    public override double divide(double num1, double num2) //override the method divide, also applying Polymorphism
    { // creating a method divide, with 2 parameters (double num1, double num2)
        return num1 / num2; // return the computation to the main class
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n*****************************************************");
        Console.WriteLine("                      CALCULATOR                     "); // Header
        Console.WriteLine("*****************************************************");

        Calculator calculation = new Calculator(); // creating an object named "calculation" from the class Calculator (line 1)
        double num1, num2;
        string choice; // string choice was used to have the user decide whether exit the program or do another calculation
        string operation = "";
        bool isExit = false; // used to perform the loop for exit or redo

        while (!isExit) // using while loop to add exit or redo option for the user
        {
            Console.Write("\nEnter 1st number: ");

            if (!double.TryParse(Console.ReadLine(), out num1)) // identify if the user inputed the right format, (numeric format)
            {
                Console.Write("\nInvalid Input! Terminating system... \nPress any key to exit...");
                Console.ReadKey();
                return; // if not in a numeric format, the system will terminate.
            }

            calculation.getNum1(num1);

            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.Write("Enter Operation (+, -, *, /): ");
                operation = Console.ReadLine();

                if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                {
                    Console.WriteLine("Invalid Operation!");
                    Console.WriteLine("\n");
                }
                else
                {
                    break;
                }
            }

            calculation.getOperation(operation);

            Console.Write("Enter 2nd number: ");
            while (!double.TryParse(Console.ReadLine(), out num2)) // ensure that the user types a numerical value
            {
                Console.WriteLine("Invalid Input! Please enter a valid number.\n");
                Console.Write("Enter 2nd number: ");
            }

            calculation.getNum2(num2);

            switch (operation) // using switch to implement conditional statement. Comparing "operation" 
            {
                case "+": // in case that the operation is equals to +
                    Console.WriteLine($"\n\tThe calculated result is:\n\n\t{num1} + {num2} = {calculation.add(num1, num2)}"); // calling the object method, passing the parameters (num1, num2)
                    break; // break the case statement
                case "-": // in case that the operation is equals to -
                    Console.WriteLine($"\n\tThe calculated result is:\n\n\t{num1} - {num2} = {calculation.subtract(num1, num2)}"); // calling the object method, passing the parameters (num1, num2)
                    break; // break the case statement
                case "*": // in case that the operation is equals to *
                    Console.WriteLine($"\n\tThe calculated result is:\n\n\t{num1} * {num2} = {calculation.multiply(num1, num2)}"); // calling the object method, passing the parameters (num1, num2)
                    break; // break the case statement
                case "/": // in case that the operation is equals to /
                    Console.WriteLine($"\n\tThe calculated result is:\n\n\t{num1} / {num2} = {calculation.divide(num1, num2)}"); // calling the object method, passing the parameters (num1, num2)
                    break; // break the case statement
                default: // this is the else statement, in case the operation is different
                    Console.WriteLine("Invalid Operation!");
                    break; // break the case statement
            }

            Console.Write("\n\nType Y to try again, press any other key to exit: ");
            choice = Console.ReadLine();

            if (choice != "Y" && choice != "y")
            {
                isExit = true; // if the user type any key beside Y or y, then the boolean isExit will be true, hence breaking the while loop 
            }
            else
            {
                operation = "";
            }
        }
    }
}

/* 
User input: Done
Invalid message display if not numerical: Done
Termination if input is invalid: Done
Invalid Operation display: Done
Input another numerical value if operation is valid: Done
Display the result if input is already valid: Done
Another Calculation: Done
 */
