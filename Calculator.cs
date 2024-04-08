using System;

namespace Calculatorassignment
{
    //Parent Class
    class Calculator
    {
        //Encapsulation for private fields
        private double first_value;

        //getter and setter for abstraction
        public double First_value
        {
            get { return first_value; }
            set { first_value = value; }
        }

        public Calculator() { }
        public Calculator(double First_value)
        {
            first_value = First_value;
        }

        // Calculations for the operators
        public double Calculation(double second_value, char operatorchoice)
        {
            double result = 0;
            try
            {
                switch (operatorchoice)
                {
                    case '+':
                        result = First_value + second_value;
                        break;

                    case '-':
                        result = First_value - second_value;
                        break;

                    case '*':
                        result = First_value * second_value;
                        break;

                    case '/':
                        result = First_value / second_value;
                        break;

                    default:
                        Default();
                        break;
                }
            }
            catch
            {
                Console.Write("Invalid value. Please enter a valid number: ");
            }
            return result;
        }
        private void Default()
        {
            Console.Write("Invalid operator. Please enter a valid operator (+, -, *, /, =):");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //using do-while loop to repeat the process if the user wants to calculate again
                string choice;
                do
                {
                    Console.Write("Enter a value: ");
                    double First_value;
                    while (!double.TryParse(Console.ReadLine(), out First_value))
                    {
                        Console.Write("Invalid value. Please enter a valid number: ");
                    }

                    char operatoruse;
                    bool validOperator = false;
                    do
                    {
                        Console.WriteLine("+ - * / ");
                        Console.Write("Choose operator to use: ");
                        if (!char.TryParse(Console.ReadLine(), out operatoruse))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid operator.");
                            continue;
                        }

                        if (operatoruse == '+' || operatoruse == '-' || operatoruse == '*' || operatoruse == '/')
                        {
                            validOperator = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /).");
                        }
                    } while (!validOperator);


                    Console.Write("Enter a value: ");
                    double second_value;
                    while (!double.TryParse(Console.ReadLine(), out second_value))
                    {
                        Console.Write("Invalid value. Please enter a valid number: ");
                    }

                    Calculator calculator = new Calculator(First_value);
                    double result = calculator.Calculation(second_value, operatoruse);

                    while (true)
                    {
                        Console.WriteLine("\n+ - * / ");
                        Console.Write("Choose operator to use (Enter an = to finish): ");
                        if (!char.TryParse(Console.ReadLine(), out operatoruse))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid operator.");
                            continue;
                        }

                        if (operatoruse == '=')
                            break;

                        if (operatoruse == '+' || operatoruse == '-' || operatoruse == '*' || operatoruse == '/')
                        {
                            validOperator = true;
                        }
                        else
                        {
                            Console.Write("Invalid operator. Please enter a valid operator (+, -, *, /): ");
                            continue;
                        }

                        do
                        {
                            Console.Write("\nEnter a value: ");
                        } while (!double.TryParse(Console.ReadLine(), out second_value));


                        calculator.First_value = result;
                        result = calculator.Calculation(second_value, operatoruse);
                    }

                    Console.WriteLine($"The result will be: {result}");

                    Console.Write("\nDo you want to make another calculation? (Yes/No): ");
                    choice = Console.ReadLine().ToLower();
                } while (choice == "yes");

                if (choice == "no")
                {
                    Console.WriteLine("End of Program");
                }

            }
            catch
            {
                Console.WriteLine("Invalid Value.");
            }
        }
    }
}
