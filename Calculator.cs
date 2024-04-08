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
                    Console.WriteLine("\n\t+(Additon)\n\t-(Subtraction)\n\t*(Multiplication)\n\t/(Division)\n\t=(See Result)");
                    Console.Write("Enter the Operator: ");
                    choiceOperator = (Console.ReadLine());
                    
                    // Check if the input is valid operator, then exit the loop if true.
                    if (choiceOperator == "+"||choiceOperator == "-"||choiceOperator == "*"||choiceOperator == "/"||choiceOperator=="=") 
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
                    if (num1 == 0)
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        num2 = Convert.ToDouble(Console.ReadLine()); 
                    }
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
            int x = 1;
            // main program loop
            do 
            {
                // Instantiate First class to get the first number.
                Second second = new Second();
                
                // Instantiate Input class to get the chosen operator.
                Input input = new Input();
                
                while (true)
                {
                        if (x == 1) //if user will enter the first number
                    {
                        second.Choice(); //calls the method (First Class)
                    }
                    else //if user will enter another number
                    {
                        second.num1 = input.result; //store the answer to the variable num1
                    }
    
                    input.Choice(); //calls the method (Enter Class)
    
                    if (input.choiceOperator == "=") //if operator is =, then it prints the result
                    {
                        Console.WriteLine($"\n The final result is {input.result}\n");
                        break;
                    }
    
                    second.Choice(); //calls the method (Second Class)
                
                    // Perform the calculation based on the chosen operator.
                    switch (input.choiceOperator) 
                    {
                        case "+": 
                            input.result = second.num1 + second.num2;
                            x = 2;
                            break;
                        case "-": 
                            input.result = second.num1 - second.num2;
                            x = 2;
                            break;
                        case "*": 
                            input.result = second.num1 * second.num2;
                            x = 2;
                            break;    
                        case "/": 
                            input.result = second.num1 / second.num2;
                            x = 2;
                            break; 
                        default:  
                            break;
                    }
                }
                // Display the result and will ask to continue or exit the program.
                Console.WriteLine("\nWould you like to do another calculation?");
                Console.Write("Enter 'Y' to continue and enter any key to exit the program: ");
            } 
            // will continue while "Y" is entered, otherwise exit the program.
            while (Console.ReadLine().ToUpper() == "Y");
            
            Console.WriteLine("\nEnd of the Program.\n");
        }
    } 
}
