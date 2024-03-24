using CrystalynDanga;
using System.Reflection.Metadata;

/*
 * I used POLYMORPHISM AND INHERITANCE 
 * Compute() method was used as polymorphism to calculate for different operators and operands
 * the attributes for number 1, number 2, and the userchoice(operators) was inherited from the parent class
 * These attributes was passed to the main where the program prompts the user to input values.
 * Those values is then passed into subclasses (child class)
 */

namespace CrystalynDanga
{
    class Calculator  //Parent Class
    {
        //Declaring Variables
        public float n1;
        public float n2;
        public string userChoice;

        public Calculator (float n1, float n2, string userChoice) //Constructors
        {
            this.n1 = n1;
            this.n2 = n2;
            this.userChoice = userChoice;

        }

        public virtual void Compute() //Polymorphism
        {

        }

    }
    class Add : Calculator
     {
        public Add(float n1, float n2) : base(n1, n2, "+") { }
        public override void Compute() //Polymorphism 1
        {
            Console.WriteLine("The result is: " + (n1+n2));
        }

    }
    class Subtraction : Calculator
    {

        public Subtraction(float n1, float n2) : base(n1, n2, "-") { }
        public override void Compute() //Polymorphism 2 
        {
            Console.WriteLine("The result is: " + (n1 - n2));
        }
    }

    class Multiplication : Calculator
    {

        public Multiplication(float n1, float n2) : base(n1, n2, "*") { }
        public override void Compute() //Polymorphism 3
        {
            Console.WriteLine("The result is: " + (n1 * n2));
        }
    }
    class Division : Calculator
    {

        public Division(float n1, float n2) : base(n1, n2, "/") { }
        public override void Compute() //Polymorphism 4
        {
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("Cannot be divided!");
            }
            else
                Console.WriteLine("The result is: " + (n1 / n2));
        }
    }

        
 }
class Program
{
    static void Main(string[] args)
    {
        try
        {
            while (true) 
            {
                Console.Write("Enter a number 1: "); //First Value
                float n1 = float.Parse(Console.ReadLine());

                //Prompts user to input operator
                Console.WriteLine("\nChoose an operator (ONLY ENTER THE OPERATOR SYMBOL)");
                Console.WriteLine("1. Add (+)\n2. Subtraction (-)\n3. Multiplications (*)\n4. Division (/)");
                Console.Write("Enter your choice: ");
                string userChoice = Console.ReadLine();

                if (userChoice != "+" && userChoice != "-" && userChoice != "*" && userChoice != "/")
                {
                    throw new InvalidOperationException(); //if operator is invalid, it will go to catch
                } // if statement

                Console.Write("\nEnter a number: "); //Second value
                float n2 = float.Parse(Console.ReadLine());

                //Computation
                switch (userChoice)
                {
                    case "+":
                        Add add = new Add(n1, n2); //instantation of class
                        add.Compute(); //Calling Polymorphism that adds the two values
                        break;
                    case "-":
                        Subtraction subtraction = new Subtraction(n1, n2); //instantation of class
                        subtraction.Compute();//Calling Polymorphism that subtracts the two values
                        break;
                    case "*":
                        Multiplication multiplication = new Multiplication(n1, n2); //instantation of class
                        multiplication.Compute();//Calling Polymorphism that multiplies the two values
                        break;
                    case "/":
                        Division division = new Division(n1, n2); //instantation of class
                        division.Compute();//Calling Polymorphism that division the two values
                        break;
                } //Switch

                //Asks the user for another computation
                while (true)
                {
                    Console.Write("\nDo you still want to compute again? (Y or N): ");
                    string inputAgain = Console.ReadLine();
                    char userInputAgain = inputAgain.ToUpper()[0]; //Converts the first letter of user's choice into upper case 

                    if (userInputAgain == 'Y')
                    {
                        break;
                    }
                    else if (userInputAgain == 'N')
                    {
                        Console.WriteLine("Arigathanks!");
                        return;
                    }
                    else //if none of the above was satisfies
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                } //nested while
                
            } // While loop
                
        } // Try 


        catch (FormatException) //If the user input is not compatible with the expected data type
        {
            Console.WriteLine("This program only accepts numerical values!");
        }
        catch (InvalidOperationException) //If the user input is not compatible with the expected operation
        {
            Console.WriteLine("Invalid Operator!");
        }
        finally //General error messaage
        {
            Console.WriteLine("Program terminated!");
        }
        }
    } //Class






