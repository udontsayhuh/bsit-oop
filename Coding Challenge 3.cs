using System;

//A program that asks a user for performing basic arithmetic calculations

class BasicArithmetic
{
    public static void Main(string[] args)
    {
        string calculateAgain; //This variable is for asking if the user wants to calculate again

        //Using do-while loop that never stops until it satisfies the condition
        do 
        {
            float num1;
            float num2; 
            //Basic Arithmetic Functions
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("CHOOSE A BASIC ARITHMENTIC FUNCTION: \n");
            Console.WriteLine("1. ADDITION");
            Console.WriteLine("2. SUBTRACTION");
            Console.WriteLine("3. MULTIPLICATION");
            Console.WriteLine("4. DIVISION");
            Console.WriteLine("---------------------------------------");

            //To enter the choice which basic arithmetic function will perform
            Console.WriteLine("ENTER YOUR CHOICE (1-4 only): ");
            int choice = int.Parse(Console.ReadLine());

            //To enter the first number
            Console.WriteLine("\nEnter the first number: ");
            num1 = float.Parse(Console.ReadLine());

            //To enter the second number
            Console.WriteLine("Enter the second number: ");
            num2 = float.Parse(Console.ReadLine());

            //Result initialized to 0 store to store the answer
            float result = 0;
            
            //Switch case statement 
            switch (choice)
            {
                case 1:
                    result = num1 + num2; //addition
                    break;

                case 2:
                    result = num1 - num2; //subtraction
                    break;

                case 3:
                    result = num1 * num2; //multiplication
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2; //division
                    }
                    else
                    {
                        result = 0;
                    }
                    break;

                default:
                    Console.WriteLine("\nInvalid Operation!");
                    break;
            }

            //To display the result
            Console.WriteLine("THE RESULT IS: " + result);

            //To ask the user of he/she wants to calculate again
            Console.WriteLine("\nDo you want to calculate again? (yes/no): ");
            calculateAgain = Console.ReadLine();
        }

        //If yes, the program will continue
        while (calculateAgain.ToLower() == "y" || calculateAgain.ToLower() == "yes");

        //If no, the program will terminate
        if (calculateAgain.ToLower() == "no" || calculateAgain.ToLower() == "n");
        Console.WriteLine("\nPROGRAM TERMINATED.");
    }
}
