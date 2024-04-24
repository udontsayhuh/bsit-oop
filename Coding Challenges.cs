using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            bool BackOrContinueOption = false;

            //Using a while loop to determine if the user wants to exit the code.
            while (!BackOrContinueOption)
            {

                Console.WriteLine("A. Sum and Product of two number");
                Console.WriteLine("B. Number of words");
                Console.WriteLine("C. Basic Arithmetic Functions.");
                Console.WriteLine("D. Multiplier");
                Console.WriteLine("E. Sorting List");
                Console.WriteLine("0. Done/Back");

                //Prompt the user to select a coding challenge.
                Console.Write("\nEnter your choice: ");
                char UserChoice = Console.ReadLine().ToUpper()[0];

                // Using a switch case to enable the user to choose their preferred option.
                switch (UserChoice)
                {
                    case 'A':
                        SumAndProduct();
                        break;

                    case 'B':
                        CountOfWords();
                        break;

                    case 'C':
                        BasicArithmetic();
                        break;

                    case 'D':
                        Multiplier();
                        break;

                    case 'E':
                        SortedCarList();
                        break;

                    case '0':
                        BackOrContinueOption = true;
                        Console.WriteLine("\nProgram Exit..\n ");
                        Console.ReadLine().ToUpper();
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Try again.\n ");
                        break;
                }
            }
        }

        // For First Question in Coding Challenges
        // To encapsulates the functionality for calculating the sum and product of integers and doubles
        private static void SumAndProduct()
        {
    
            // Declaring Variables
            int FirstValue;
            double FirstNum;
            int SecondValue;
            double SecondNum;

            //It will display prior to the start of the program
            Console.WriteLine("\nSum and Product of integers and double.");

            // Using a loop to ensure only valid integers are accepted for entry. 
            // For First Integer 
            while (true)
            {
                Console.Write("\nEnter the first integer: ");
                if (int.TryParse(Console.ReadLine(), out FirstValue))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid integer.");
                }
            }

            // Using a loop to ensure only valid integers are accepted for entry. 
            // For Second Integer 
            while (true)
            {
                Console.Write("Enter the second integer: ");
                if (int.TryParse(Console.ReadLine(), out SecondValue))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid integer.");
                }
            }

            // Using a loop to ensure only valid doubles are accepted for entry.
            // For First Double 
            while (true)
            {
                Console.Write("\nEnter the first double: ");
                if (double.TryParse(Console.ReadLine(), out FirstNum))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid number.");
                }
            }

            // Using a loop to ensure only valid doubles are accepted for entry.
            // For Second Double 
            while (true)
            {
                Console.Write("Enter the second double: ");
                if (double.TryParse(Console.ReadLine(), out SecondNum))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid number.");
                }
            }

            //Calculation and display of the sum of first and second integer.
            int intSum = FirstValue + SecondValue;
            Console.WriteLine($"\nSum of integers: {intSum}");

            //Calculation and display of the sum of first and second double.
            double doubleSum = FirstNum + SecondNum;
            Console.WriteLine($"Sum of doubles: {doubleSum}");

            //Calculating and displaying the product derived from the sum of integers and doubles.
            double ValueProduct = intSum * doubleSum;
            Console.WriteLine($"\nProduct of sum values: {ValueProduct}");

            // Displays a prompt and asking the user to press any key or enter to restart the program,
            // which will then return to the UserChoice.
            Console.Write("\nExit Program.. Press any key or enter to restart.");
            string UserDecision = Console.ReadLine().ToUpper();

            if (UserDecision == "0")
            {
                return;
            }
        }

        // For Second Question in Coding Challenges
        // This method includes capability for counting words and modifying a provided string.
        private static void CountOfWords()
        {
            // Asking the user to enter a string.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();


            //Using split function to divide the words
            string[] word = input.Split(new char[] { ' ' });

            // Counting and displaying the number of words
            int WordCount = word.Length;
            Console.WriteLine($"\nWord Counts: {WordCount}");

            //Converting and displaying the user input into uppercases.
            Console.WriteLine($"\nWord/s in uppercases: {input.ToUpper()}\n");

            // Displays a prompt and asking the user to press any key or enter to restart the program,
            // which will then return to the UserChoice.
            Console.Write("\nExit Program.. Press any key or enter to restart. ");
            string UserDecision = Console.ReadLine().ToUpper();

            if (UserDecision == "0")
            {
                return;
            }

        }


        // For Third Question in Coding Challenges
        // This method is internal, has no return value, and does not require an instance.
        private static void BasicArithmetic()
        {
            //Variables to hold numbers and the result
            double number1 = 0, number2 = 0, result = 0;
            char operatorChar;
            bool validOperation = true;

            // Using while loop to get only a valid arithmetic operator.
            while (true)
            {
                Console.WriteLine("+ = Addition");
                Console.WriteLine("- = Subtraction");
                Console.WriteLine("* = Multiplication");
                Console.WriteLine("/ = Division");
                Console.Write("\nEnter the operator : ");
                operatorChar = Console.ReadKey().KeyChar;
                Console.WriteLine();

                //To validate operator
                if (operatorChar == '+' || operatorChar == '-' || operatorChar == '*' || operatorChar == '/')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid operator. Must enter a valid operator. \n");

                }
            }

            //Loop function to get a valid first value.
            while (true)
            {
                Console.Write("Enter the first number: ");
                if (double.TryParse(Console.ReadLine(), out number1))
                {
                    break;
                }
                else
                {
                    //This will print if the user input a invalid value.
                    Console.WriteLine("\nInvalid Value, Please enter a valid value.");

                }
            }

            //Loop function to get a valid second value.
            while (true)
            { 
                Console.Write("Enter the second number: ");
                if (double.TryParse(Console.ReadLine(), out number2))
                {
                    break;
                }
                else
                {
                    //This will print if the user input a invalid value.
                    Console.WriteLine("\nInvalid Value, Please enter a valid value.");
                }
            }

            //Initialize result and operation validity
            result = 0;
            validOperation = true;

            //Using switch case to perform operation based on valid operator.
            switch (operatorChar)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    validOperation = false;
                    break;
            }

            //This method will display if the operation is valid.
            if (validOperation)
            {
                Console.WriteLine($"\nThe Result of {number1} {operatorChar} {number2} = {result}");
            }

            // Displays a prompt and asking the user to press any key or enter to restart the program,
            // which will then return to the UserChoice.
            Console.Write("\nExit Program.. Press any key or enter to restart. ");
            string UserDecision = Console.ReadLine().ToUpper();

            if (UserDecision == "0")
            {
                return;
            }

        }

        //For Fourth Question in Coding Challenges
        // This function generates a multiplication table for a user-specified base number and multiplier.
        private static void Multiplier()
            {

            //Declaring variables
            double baseNumber;
            int multiplier;

            // Asking the user for valid number to be multiplied
            Console.Write("Enter number to be multiplied: ");
            while (!double.TryParse(Console.ReadLine(), out baseNumber))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            // Asking the user for another valid number to get the multiplier
            Console.Write("Enter a number to be multiplier: ");
            while (!int.TryParse(Console.ReadLine(), out multiplier) || multiplier < 0)
            {
                Console.Write("Invalid input. Please enter a non-negative and valid number: ");
            }

            // Displaying the multiplication table up to the multiplier that the user input.
            Console.WriteLine($"Multiplication table of {baseNumber} and {multiplier}.");
            for (int i = 1; i <= multiplier; i++)
            {
                Console.WriteLine($"{baseNumber} x {i} = {baseNumber * i}");
            }

            // Displays a prompt and asking the user to press any key or enter to restart the program,
            // which will then return to the UserChoice.
            Console.Write("\nExit Program.. Press any key or enter to restart. ");
            string UserDecision = Console.ReadLine().ToUpper();

            if (UserDecision == "0")
            {
                return;
            }

        }

        // For Fifth Question in Coding Challenges
        // This function arranges a predefined array of car names alphabetically and shows them.
        private static void SortedCarList()
        {
            // Declaring array of car names
            string[] cars = { "Toyota", "Honda", "BMW", "Ford", "Chevrolet" };

            // Displaying car arrays based on original list
            Console.WriteLine("Original list of cars: \n");
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i]);

            // Displaying a line for sorted list of cars
            Console.WriteLine("\nSorted list of cars: \n");

            // using .Sort(); method to sort car names into alphabetical order.
            Array.Sort(cars);
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i]);

            // Displays a prompt and asking the user to press any key or enter to restart the program,
            // which will then return to the UserChoice.
            Console.Write("\nExit Program.. Press any key or enter to restart. ");
            string UserDecision = Console.ReadLine().ToUpper();

            if (UserDecision == "0")
            {
                return;
            }

        }
            private static void Default()
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
