using System;

namespace Calculatorassignment
{
    //Parent Class
    class Calculator
    {
        //Encapsulation for private fields
        private double first_value;
        private double second_value;

        //getter and setter for abstraction
        public double First_value
        {
            get { return first_value; }
            set { first_value = value; }
        }
        public double Second_value
        {
            get { return second_value; }
            set { second_value = value; }
        }

        public Calculator() { }
        public Calculator(double First_value, double Second_value)
        {
            first_value = First_value;
            second_value = Second_value;
        }

    
    // Calculations for the operators
    public void Calculation(double operatorchoice)
    {
     try 
        { 
        switch (operatorchoice)
        {
            case '+' :
                   Console.Write("\nEnter a value: ");
                   double Second_value_sum = Convert.ToDouble(Console.ReadLine());
                   double sum = First_value + Second_value_sum ;
                   Console.WriteLine($"\nThe sum of {First_value} and {Second_value_sum} is equal to {sum}");
                   break;

            case '-' :
                  Console.Write("\nEnter a value: ");
                  double Second_value_min = Convert.ToDouble(Console.ReadLine());
                  double subtract = First_value - Second_value_min ;
                  Console.WriteLine($"\nThe subtraction of {First_value} and {Second_value_min} is equal to {subtract}\n");
                  break;

            case '*' :
                    Console.Write("\nEnter a value: ");
                    double Second_value_multiply = Convert.ToDouble(Console.ReadLine());
                    double product = First_value * Second_value_multiply;
                    Console.WriteLine($"\nThe product of {First_value} and {Second_value_multiply} is equal to {product}\n");
                    break;

            case '/' :
                    Console.Write("\nEnter a value: ");
                    double Second_value_divide = Convert.ToDouble(Console.ReadLine());
                    double quotient = First_value / Second_value_divide ;
                    Console.WriteLine($"\nThe quotient of {First_value} and {Second_value_divide} is equal to {quotient}\n");
                    break;
              
                default:
                Default();
                break;
                }
            }
            catch 
            {
                Console.WriteLine("Invalid Value."); 
            }
    }
    private void Default()
        {
        Console.WriteLine("Invalid Operator");
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
            try
            {
                // Printing line for the first value.
                Console.Write("Enter a value: ");
                double First_value = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n+ - * / ");
                Console.Write("Choose operator to use: ");
                int operatorchoice = Convert.ToChar(Console.ReadLine());

                Calculator calculator = new Calculator();
                calculator.First_value = First_value;
                calculator.Calculation(operatorchoice);
                 
            }
            catch
            {
                // This will print if the value is not numerical.
               Console.WriteLine("Invalid Value.");
            }

        }
        }
}
