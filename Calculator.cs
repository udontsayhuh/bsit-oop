using System;

namespace Calculatorcs
{
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
        public double Calculation(double second_value, char operatorChoice)
        {
            double result = 0;
            try
            {
                switch (operatorChoice)
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
                Console.Write("Invalid value. \nPlease enter a valid number: ");
            }
            return result;
        }
        private void Default()
        {
            Console.Write("Invalid operator. \nPlease enter a valid operator (+, -, *, /, =):");
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
                            Console.Write("Invalid value. \nPlease enter a valid number: ");
                        }

                        char operatorUse;
                        bool validOperator = false;
                        do
                        {
                            Console.WriteLine("\n+ - * / ");
                            Console.Write("Choose operator to use: ");
                            if (!char.TryParse(Console.ReadLine(), out operatorUse))
                            {
                                Console.WriteLine("Invalid input. \nPlease enter a valid operator.");
                                continue;
                            }

                            if (operatorUse == '+' || operatorUse == '-' || operatorUse == '*' || operatorUse == '/')
                            {
                                validOperator = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid operator. \nPlease enter a valid operator (+, -, *, /).");
                            }
                        } while (!validOperator);


                        Console.Write("Enter a value: ");
                        double second_value;
                        while (!double.TryParse(Console.ReadLine(), out second_value))
                        {
                            Console.Write("Invalid value. \nPlease enter a valid number: ");
                        }

                        Calculator calculator = new Calculator(First_value);
                        double result = calculator.Calculation(second_value, operatorUse);

                        while (true)
                        {
                            Console.WriteLine("\n+ - * / ");
                            Console.Write("Choose operator to use (Enter an = to finish): ");
                            if (!char.TryParse(Console.ReadLine(), out operatorUse))
                            {
                                Console.WriteLine("Invalid input. \nPlease enter a valid operator.");
                                continue;
                            }

                            if (operatorUse == '=')
                                break;

                            if (operatorUse == '+' || operatorUse == '-' || operatorUse == '*' || operatorUse == '/')
                            {
                                validOperator = true;
                            }
                            else
                            {
                                Console.Write("Invalid operator. \nPlease enter a valid operator (+, -, *, /): ");
                                continue;
                            }

                            Console.Write("Enter a value: ");
                            while (!double.TryParse(Console.ReadLine(), out second_value))
                            {
                                Console.Write("Invalid value. \nPlease enter a valid number: ");
                            }

                            calculator.First_value = result;
                            result = calculator.Calculation(second_value, operatorUse);
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
}

