using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Abstract Class
    abstract class Arithemtic
    {
        //Abstract Method
        public abstract double GetResult(double x, double y);
    }

    //Inheritance
    class Addition : Arithemtic
    {
        
        //Polymorphism
        //Override inherited method
        public override double GetResult(double x, double y)
        {
            return x + y;
        }
    }

    //Inheritance
    class Subtraction : Arithemtic
    {

        //Override inherited method
        public override double GetResult(double x, double y)
        {
            return x - y;
        }
    }

    //Inheritance
    class Multiplication : Arithemtic
    {

        //Override inherited method
        public override double GetResult(double x, double y)
        {
            return x * y;
        }
    }

    //Inheritance
    class Division : Arithemtic
    {

        //Override inherited method
        public override double GetResult(double x, double y)
        {
            return x / y;
        }
    }

    class Calculator
    {
        //Attributes
        public double num1, num2;
        public char operation;
        public bool retry;

        //Attribute Object
        //The attribute can have the instance from any children of the Arithmetic class
        private Arithemtic Operation;
        
        //Methods
        public double GetNum()
        {
          
            while (true){
                try
                {
                    //Get a Double value from the user
                    Console.Write("\nEnter a Number: ");
                    double num = Convert.ToDouble(Console.ReadLine());

                    //Condition is for the second number input only
                    //Check if the second number is Zero and Division has been selected
                    if(operation == '/' && num == 0)
                    {
                        //Show Message and Continue the input loop
                        Console.WriteLine("\nCannot Divide By 0!\n");
                        continue;
                    }

                    //Input is Valid, so get out of the method
                    return num;

                }

                //If input is not a number catch block will execute
                catch (FormatException e)
                {
                    
                    Console.WriteLine("\nInvalid Input");
                    Console.WriteLine("Terminating Program\n");

                    //Exit the Program
                    Environment.Exit(1);

                    //This will not execute
                    //Only exist for removing error
                    return 1;

                }
            }
        }

        public char GetOperation()
        {

            while (true)
            {
                
                char operation = ' ';

                //Keep looping until input is valid
                while (operation != '+' && operation != '-' && operation != '*' && operation != '/')
                {

                    Console.Write("\nEnter an Operation (+,-,*,/): ");
                    operation = Convert.ToChar(Console.Read());
                    Console.ReadLine();

                    //Create an Object Based on the input operation
                    //Set the value of the Attribute Operation to the new Object associated with the input operation
                    switch (operation)
                    {
                        case '+':
                            Operation = new Addition();
                            break;
                        case '-':
                            Operation = new Subtraction();
                            break;
                        case '*':
                            Operation = new Multiplication();
                            break;
                        case '/':
                            Operation = new Division();
                            break;
                        default:
                            //Show Message that input is invalid
                            Console.WriteLine("\nInput a Correct Operation!\n");
                            break;
                    }
                }

                return operation;

            }

        }

        public string GetResult()
        {
            //Return a String of the Result using the attributes in the class
            //Get the associated GetResult method from the x child of Arithmetic
            return $"{num1} {operation} {num2} = {Operation.GetResult(num1, num2)}";
        }

        public void TryAgain()
        {
            char reply = ' ';

            //Keep looping until input is valid
            while (reply != 'Y' && reply != 'N')
            {
                
                //Input for character
                Console.Write("\nWould you like to input again? (Y:N): ");
                reply = Char.ToUpper(Convert.ToChar(Console.Read()));
                Console.ReadLine();

            }

            //Change the value of attribute retry based on reply
            retry = (reply == 'Y') ? true : false;
        }
    }
        
    class Program
    {
      
        static void Main(string[] args)
        {

            //Create Object
            Calculator calculator = new Calculator();

            //Keep looping while the retry attribute is true
            do
            {
                //Set Values for the attributes in the Object
                calculator.num1 = calculator.GetNum();
                calculator.operation = calculator.GetOperation();
                calculator.num2 = calculator.GetNum();

                Console.WriteLine(calculator.GetResult());

                calculator.TryAgain();

            } while (calculator.retry);

        }
    }
}
