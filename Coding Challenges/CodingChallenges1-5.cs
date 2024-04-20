using System;
using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CodingChallenges
{
    //Coding Challenge num 1
    public class Addition
    {
        private int getValue() //int
        {
            int num = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch //invalid value
                {
                    Console.WriteLine("Enter int numbers only"); //display error
                }
            }
            return num;
        }

        private double getValue2() //double
        {
            double num = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    num = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch //invalid value
                {
                    Console.WriteLine("Enter double numbers only"); //display error
                }
            }
            return num;
        }

        public void Sum()
        {
            Console.WriteLine("");
            Console.WriteLine("Getting Value for Integer:");
            int num1 = getValue();
            int num2 = getValue();
            Console.WriteLine($"Sum: {num1 + num2}");
            double sum1= num1 + num2;

            Console.WriteLine("");
            Console.WriteLine("Getting Value for Double:");
            double num3 = getValue2();
            double num4 = getValue2();
            Console.WriteLine($"Sum: {num3 + num4}");
            double sum2 = num3 + num4;
            Console.WriteLine("");
            Console.WriteLine($"{sum1} x {sum2} = {sum1 * sum2}");
        }
    }


    //Coding Challenge num 2
    public class WordCounter
    {
        private string text;
        private string GetMessage()
        {
            Console.WriteLine("Enter a Message: ");
            text = Console.ReadLine();
            return text;
        }

        public void Count()
        {
            string text = GetMessage();
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            int counter = text.Split(separator: delimiters, options: StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Words : {counter}");
        }
    }


    //Coding Challenge num 3
    public class Calculator()
    {
        private double getValue() 
        {
            double num = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    num = Convert.ToDouble(Console.ReadLine());//value for num
                    break;
                }
                catch //invalid value
                {
                    Console.WriteLine("Enter numbers only"); //display error
                }
            }
            return num;
        }

        private string opt()
        {
            string Operation;
            do
            {
                Console.Write("Select Operator [+, -, *, /]: ");
                Operation = Console.ReadLine();
            } while (Operation != "+" && Operation != "-" && Operation != "*" && Operation != "/");
            return Operation;
        }

        public void Calculate()
        { bool repeat = true;
            do
            {
                Console.Clear();
                string response;
                double num1 = getValue();
                string Operation = opt();
                double num2 = getValue();

                switch (Operation)
                {
                    case "+":
                        Console.WriteLine($"Answer: {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Answer: {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Answer: {num1 * num2}");
                        break;
                    case "/":
                        Console.WriteLine($"Answer: {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Failed to Calculate");
                        break;
                }
                do
                {
                    Console.WriteLine("Do you want to calculate again [Y(yes) or N(no)]");
                    response = Console.ReadLine();
                    response = response.ToLower();
                } while (response != "y" && response != "n" && response != "yes" && response != "no");

                if (response == "n" || response == "no")
                    repeat = false;

            } while (repeat);
        }


        //Code Challenge num 4
        public class Multiplication
        {
            private double GetValue() 
            {
                double num = 0;
                while (true)
                {
                    try
                    {
                        num = Convert.ToDouble(Console.ReadLine());//value for num
                        break;
                    }
                    catch //invalid value
                    {
                        Console.WriteLine("Enter numbers only"); //display error
                    }
                }
                return num;
            }
            public void Multiples()
            {
                Console.Write("Enter a number:");
                double num1 = GetValue();
                Console.Write("Enter a multiplier:");
                double num2 = GetValue();

                for (int i = 0; i <= num2; i++)
                {
                    Console.WriteLine($"{num1} x {i} = {num1 * i}");
                }

            }
        }


        //code challenge num 5
        public class Cars
        {
            string[] cars = { "Tesla", "Honda", "Ford", "Ferrari" };
            public void Sorting()
            {
                Console.WriteLine("");
                Console.WriteLine("unsorted:");
                foreach (string i in cars)
                {
                    Console.WriteLine(i);
                }
                Array.Sort(cars);
                Console.WriteLine("");
                Console.WriteLine("Sorted:"); ;
                foreach (string i in cars)
                {
                    Console.WriteLine(i);
                }
            }
        }


        class CodingChallange
        {
            static void Main(string[] args)
            {
                bool repeat = true;
                string menu = "0";
                string response;
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("=======================================");
                        Console.WriteLine("           CODING CHALLENGE            ");
                        Console.WriteLine("=======================================");
                        Console.WriteLine("1. Addition");
                        Console.WriteLine("2. Word Counter");
                        Console.WriteLine("3. Calculator");
                        Console.WriteLine("4. Multiplication");
                        Console.WriteLine("5. Array Sort");
                        Console.WriteLine("");
                        Console.Write("Select item no. [1-5]: ");
                        menu = Console.ReadLine();
                        Console.WriteLine("");

                    } while (menu != "1" && menu != "2" && menu != "3" && menu != "4" && menu != "5");

                    switch (menu)
                    {
                        case "1":
                            Addition addition = new Addition();
                            addition.Sum();
                            break;
                        case "2":
                            WordCounter counter = new WordCounter();
                            counter.Count();
                            break;
                        case "3":
                            Calculator calculator = new Calculator();
                            calculator.Calculate();
                            break;
                        case "4":
                            Multiplication multiplication = new Multiplication();
                            multiplication.Multiples();
                            break;
                        case "5":
                            Cars cars = new Cars();
                            cars.Sorting();
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }

                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Check Other Coding Solution? [Y or N]: ");
                        response = Console.ReadLine();
                        response = response.ToUpper();
                    } while (response != "Y" && response != "N");
                    if (response == "N")
                    {
                        repeat = false;
                    }
                } while (repeat);
            }
        }
    }
}
