using System;

namespace SimpleCalculator 
{
    // Base or parent class for user input.
    class Input 
    {
        // Fields to store numbers, result, and operator used.
        // Encapsulation: Fields are encapsulated, accessed and modified only through class methods.
        public double num1;
        public double num2;
        public double result;
        public string choiceOperator;
        
        // Method that promts to choose an operator.
        // Encapsulation: The method encapsulates the logic for obtaining the chosen operator.
        // Polymorphism: The method marked a virtual to allow sub-classes to provide their own implementations.
        public virtual void Choice() 
        {
            // Loop to continue asking for valid input, will end if input is from the choices operator.
            while (true) 
            {
                // to catch the error and execute code to handle it
                try 
                {
                    // display the operators
                    Console.WriteLine("\n\t+(Additon)\n\t-(Subtraction)\n\t*(Multiplication)\n\t/(Division)");
                    Console.Write("Enter the Operator: ");
                    choiceOperator = (Console.ReadLine());
                    
                    // Check if the input is valid operator, then exit the loop if true.
                    if (choiceOperator == "+"||choiceOperator == "-"||choiceOperator == "*"||choiceOperator == "/") 
                    {
                        break;
                    }
                    // Invalid input will throw a FormatException.
                    else 
                    {
                        throw new FormatException();
                    }
                }
                // Catch the FormatException that occcur due to invalid input and print error message.
                catch
                {
                    Console.WriteLine("Invalid Input. Please choose from the Four Operators only.");
                }
            }
        }
    }
    
    // Class for handling the first number input.
    // Inheritance: First class inherit the properties and methods define in the Input class.
    class First : Input 
    {
        // Polymorphism: Override the base class method to provide specialized behavior.
        // Override the Choice method to handle the first number input.
        public override void Choice() 
        {
            // to catch the error and execute code to handle it
            // Catch FormatException occurs due to invalid input, will display error message and exit the program
            try 
            {
               Console.Write("\nEnter the First Number: ");
               // Read and convert the code from string to double.
               num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException) 
            {
                Console.WriteLine("Invalid Input. End of the Program.");
                Environment.Exit(0);
            }
        }
    }
    
    // Class for handling the second number input.
    // Inheritance: Second class inherit the properties and methods define in the Input class.
    class Second : Input 
    {
        // Polymorphism: Override the base class method to provide specialized behavior.
        // Override the Choice method to handle the second number input.
        public override void Choice() 
        {
            // Loop to continue asking for valid input, will end if input is valid numeric.
            while (true) 
            {
                // to catch the error and execute code to handle it inside the loop
                // Catch FormatException occurs due to invalid input, will display error message. 
                try 
                {
                    Console.Write("\nEnter the Second Number: ");
                    // Read and convert the code from string to double, if valid input then exit the loop.
                    num2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Invalid Input. Only numeric value is accepted.");
                }
            }
        }
    }
    
    // Main Program
    class Program 
    {
        static void Main(string[] args) 
        {
            // main program loop
            do 
            {
                // Instantiate First class to get the first number.
                First first = new First();
                first.Choice();
                
                // Instantiate Input class to get the chosen operator.
                Input input = new Input();
                input.Choice();
                
                // Instantiate Second class to get the second number.
                Second second = new Second();
                second.Choice();
                
                // Perform the calculation based on the chosen operator.
                switch (input.choiceOperator) 
                {
                    case "+": 
                        input.result = first.num1 + second.num2;
                        break;
                    case "-": 
                        input.result = first.num1 - second.num2;
                        break;
                    case "*": 
                        input.result = first.num1 * second.num2;
                        break;    
                    case "/": 
                        input.result = first.num1 / second.num2;
                        break; 
                    default:  
                        break;
                }
                // Display the result and will ask to continue or exit the program.
                Console.WriteLine("The Result: " + input.result);
                Console.WriteLine("\nWould you like to do another calculation?");
                Console.Write("Enter 'Y' to continue and enter any key to exit the program: ");
            } 
            // will continue while "Y" is entered, otherwise exit the program.
            while (Console.ReadLine().ToUpper() == "Y");
            
            Console.WriteLine("\nEnd of the Program.\n");
        }
    } 
}
