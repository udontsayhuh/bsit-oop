using System;

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
        public override double GetResult(double x, double y) => x + y;
    }

    //Inheritance
    class Subtraction : Arithemtic
    {

        //Override inherited method
        public override double GetResult(double x, double y) => x - y;
    }

    //Inheritance
    class Multiplication : Arithemtic
    {

        //Override inherited method
        public override double GetResult(double x, double y) => x * y;
    }

    //Inheritance
    class Division : Arithemtic
    {

        //Override inherited method
        public override double GetResult(double x, double y) => x / y;
    }

    class Calculator
    {
        //Attributes
        private double _num, _result;
        private char _operation;
        public bool Retry;

        //Attribute Object
        //The attribute can have the instance from any children of the Arithmetic class
        private Arithemtic Operation;

        //Methods
        public void Main()
        {
            //Initialize Boolean to True
            bool firstIteration = true;

            while (true)
            {

                if (firstIteration)
                {

                    //Get First Input
                    _result = GetNum();

                    //Set as False, so this if block doesn't execute anymore
                    firstIteration = false;
                }

                _operation = GetOperation();

                //Get out of Main Method if User Input is Terminate
                if (_operation == '=')
                {
                    Console.WriteLine($"\nResult is {_result}");
                    return;
                }

                _num = GetNum();
                GetResult();

            }

        }

        private double GetNum()
        {

            while (true)
            {
                try
                {
                    //Get a Double value from the user
                    Console.Write("Enter a Number: ");
                    double num = Convert.ToDouble(Console.ReadLine());

                    //Condition is for the second number input only
                    //Check if the second number is Zero and Division has been selected
                    if (_operation == '/' && num == 0)
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

                    Console.WriteLine("\nInvalid Input\nTry Again!");

                }
            }
        }

        private char GetOperation()
        {

            while (true)
            {

                char operation = ' ';

                //Keep looping until input is valid
                while (operation != '+' && operation != '-' && operation != '*' && operation != '/' && operation != '=')
                {

                    Console.Write("Enter an Operation (+,-,*,/)\nOr an Equal Sign(=) to Terminate\n: ");
                    string temp = Console.ReadLine();

                    //If String Length is longer than 1 character continue loop
                    if (temp.Length > 1)
                    {
                        Console.WriteLine("Input should only be 1 Character!");
                        continue;
                    }

                    //Get the first Character of the String
                    operation = Convert.ToChar(temp);

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
                        case '=':
                            Console.WriteLine("\nTerminating Calculator!");
                            break;
                        default:
                            Console.WriteLine("\nInput a Correct Operation!\n");
                            break;
                    }
                }

                return operation;

            }

        }

        //Get the associated GetResult method from the x child of Arithmetic
        public void GetResult() => _result = Operation.GetResult(_result, _num);
       
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
            Retry = (reply == 'Y') ? true : false;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            //Create Object
            Calculator calculator = new Calculator();

            //Keep looping while attribute retry is True
            do
            {
                calculator.Main();
                calculator.TryAgain();

            } while (calculator.Retry);

        }
    }
}
