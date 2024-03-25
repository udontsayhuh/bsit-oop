using System;
using System.Diagnostics;

namespace MyCalculator
{
    // Defining an interface (ICalculator) to represent the contract for a calculator which includes abstraction

    // Interface representing a calculator
    public interface ICalculator
    {
        float Add(float num1, float num2);
        float Subtract(float num1, float num2);
        float Multiply(float num1, float num2);
        float Divide(float num1, float num2);
    }

    // Calculator class implementing the ICalculator interface
	// encapsulating the two input numbers
    public class Calculator : ICalculator
    {
        
		private float num1;
    private float num2;

    public float Num1 { 
        get { return num1; } 
        set { num1 = value; }
    }
    public float Num2 { 
        get { return num2; } 
        set { num2 = value; }
	}
        // Method to perform addition
		
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        // Method to perform subtraction
        public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        // Method to perform multiplication
        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        // Method to perform division
        public float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero"); 
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Calculator App!");

            // Creating the instance
            ICalculator calculator = new Calculator();
		
		// Uses while loop if the user want to try again
		while(true){ 	
		    Console.WriteLine("Enter First number:");
            string num1= (Console.ReadLine());
		    
		// Checks if the input is numeric or non-numeric
           if (!float.TryParse(num1, out float fnum) )
            {
                Console.WriteLine("Invalid input. Exiting the program...");
                Environment.Exit (0);
            }
		   
		   // Using goto to use a mini loop
		   choice:
           Console.WriteLine("Enter operation that you want(+,-,*,/):");
		   string choice = Console.ReadLine();
		   
		   // Checks the input if one of the operators are inputted
		   if(choice!= "+"&& choice != "-" && choice != "*" && choice != "/" )
		   {Console.WriteLine("Invalid input.");
				goto choice;}
					
			num:		
			Console.WriteLine("Enter Second number:");
			string num2=(Console.ReadLine());
           
		   // Checks if the input is numeric or non-numeric
		   if (!float.TryParse(num2, out float snum) )
            {
                Console.WriteLine("Invalid input. Please try again...");
                goto num;
            }
		  
            
		   // switch case for the operators
			switch (choice)
        {
            case "+":
                Console.WriteLine($"The sum is: {calculator.Add(fnum,snum)}");
                break;
            case "-":
                Console.WriteLine($"The difference is: {calculator.Subtract(fnum, snum)}");
                break;
            case "*":
                Console.WriteLine($"The product is: {calculator.Multiply(fnum, snum)}");
                break;
		    case "/":
			    Console.WriteLine($"The quotient is: {calculator.Divide(fnum, snum)}");
                break;
            default:
                Console.WriteLine("Invalid input.");
				goto choice;
        }
		
		// Another goto to perform mini loop
		yesNo:
		Console.WriteLine("\nDo you want to try again?(Y/N): ");
		string yesNo= Console.ReadLine();
		
		//Checks if the user wanted to try again
		if (yesNo != "N" && yesNo != "n" && yesNo !="y" && yesNo!="Y")
		{ 
            Console.WriteLine("Invalid input, Please try again...");
            goto yesNo;
        }
		
		else if (yesNo == "N" || yesNo == "n")
		{ 
            Console.WriteLine("Thanks for using my program!");
            Environment.Exit (0);
        }
            
            }
        }
    }
}






