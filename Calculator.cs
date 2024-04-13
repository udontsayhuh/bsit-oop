    using System;
    //Implementing Abstraction
    //Implementing Polymorphism
    //Implementing Inheritance
    //Implementing Encapsulation
    //Single Responsibility already applied to abstract class Operation and its derived 4 classes that perform single responsibility on solving mathematical calculations
    //Open/Closed Principle already applied to Operation Class that is open for extension but closed to modification
    abstract class Operation
    {   //Method to execute the operation
        public abstract double Execute(double num_1, double num_2);
    }

    class Add: Operation //Addition Operation
    {
        public override double Execute(double num_1, double num_2)
        {
            return num_1 + num_2;
        }
    }

    class Subtract: Operation //Subtraction Operation
    {
        public override double Execute(double num_1, double num_2)
        {
            return num_1 - num_2;
        }
    }

    class Multiply: Operation //Multiplication Operation
    {
        public override double Execute(double num_1, double num_2)
        {
            return num_1 * num_2;
        }
    }

    class Divide: Operation //Division Operation
    {
        public override double Execute(double num_1, double num_2)
        {
            if (num_2 != 0)
                return num_1 / num_2;
            else
            {
                return 0; //return 0 if the divisor is 0
            }
        }
    }

class Calculator
{   
    public static void PerformCalculator() //Method to perform calculation
    {   //To display header
        Console.WriteLine("--------------------------------");
        Console.WriteLine("         BASIC CALCULATOR       ");
        Console.WriteLine("--------------------------------");

        string value;

        do //Using do-while loop to allow the user to calculate numbers as many as the user wants
        {
            double result = 0; //result initialized to 0 for storing the computed calculation

            double num_1; //Declaration of num_1 variable
            Console.WriteLine("\nPLEASE ENTER THE FIRST NUMBER:  "); //Prompt the user to enter the first number
            while (!double.TryParse(Console.ReadLine(), out num_1)) //To check if the user's input is valid
            {   
                //To display invalid message if the user entered invalid input 
                Console.WriteLine("\nInvalid Input! Please input another number: "); 
            }
            result = num_1; //To display the first number entered by user when '=' is encountered even though there's no another number

            while (true) //If the user's input is valid, it will now perform multiple calculations as many as user wants 
            {
                string op = InputOperator(); //To get the operator entered by user
                
                if (op == "=")
                {   //To display the result
                    Console.WriteLine("\n--------------------------------");
                    Console.WriteLine("THE RESULT IS: " + result);
                    Console.WriteLine("--------------------------------");
                    break;
                }

                double num_2; //Declaration of num_2 variable
                Console.WriteLine("\nPLEASE ENTER ANOTHER NUMBER: "); //Prompt the user to enter for another number
                while (!double.TryParse(Console.ReadLine(), out num_2)) //To check if the user's input is valid
                {   //To display invalid message if the user entered invalid input
                    Console.WriteLine("\nInvalid Input! Please input another number: ");
                }

                result = Calculate(result, op, num_2); //To perform Calculate method
            }

            //To ask the user if they want to perform calculation again
            Console.WriteLine("\nDO YOU WANT TO CALCULATE AGAIN? (yes/no): ");
            value = Console.ReadLine();
            
            //Valid inputs if the user don't want to calculate. The program will terminate
            if (value.ToLower() == "n" || value.ToLower() == "no") //removed value.ToUpper to reduce code redundancy
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("PROGRAM TERMINATED.");
                Console.WriteLine("--------------------------------");
                return;
            }
        }   
        //Valid inputs if the user wants to calculate again 
        while (value.ToLower() == "y" || value.ToLower() == "yes"); //removed value.ToUpper to reduce code redundancy
    }

    private static string InputOperator() //InputOperator method set to private to get the operator from user
    {
        string op;
        //To enter any four fundamental operator and '=' to display the result
        Console.WriteLine("\nENTER ANY FOUR FUNDAMENTAL OPERATORS TO CALCULATE (+, -, *, /) OR ENTER '=' TO DISPLAY THE RESULT: ");
        op = Console.ReadLine();
        
        //To check if the operator entered by user is valid
        if (op != "+" && op != "-" && op != "*" && op != "/" && op != "=")
        {   
            //If not valid, an error message will display
            Console.WriteLine("\nInvalid Operator! Please input another valid operator.");
            op = InputOperator(); // To prompt the user again for a valid operator
        }
        return op;
    }

    private static double Calculate(double num_1, string op, double num_2) //Calculate method set to private to perform calculation based on entered operator by user
    {
        Operation operation = null;

        switch (op) //Switch Case statement
        {
            case "+":
                operation = new Add(); //To perform Addition Operation if '+' is entered
                break;
            case "-":
                operation = new Subtract(); //To perform Subtraction Operation if '-' is entered
                break;
            case "*":
                operation = new Multiply(); //To perform Multiply Operation if '*' is entered
                break;
            case "/":
                operation = new Divide(); //To perform Division Operation if '/' is entered
                break;
            case "=":
                return num_1; //To return the first number if '=' is  by user
            default:
                break;
        }
        
        //If the operation is not null, perform the operation and return the result
        if (operation != null)
        {
            return operation.Execute(num_1, num_2);
        }
        else
            return 0; //Default to 0 if operation is null
    }

    static void Main(string[] args) //Main or entry point of a program
    {
        PerformCalculator(); //To call the PerformCalculator method
    }
}
