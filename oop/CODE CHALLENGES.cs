using System;

namespace Code_Challenges
{
    class Choices_Challenges
    {

        public void GetUserInput()
        {
            // declaring a variable
            string choices;

            while (true)
            {
                Console.Write("\n\n\nEnter your selected a selected code: ");
                choices = Console.ReadLine();

                if (choices != "1" && choices != "2" && choices != "3" && choices != "4" && choices != "5")
                {
                    Restrictions.InvalidInput();
                    continue;
                }

                switch (choices)
                {
                    case "1":
                        Console.Clear();
                        new Code_Challenges_1().Run();
                        break;
                    case "2":
                        Console.Clear();
                        new Code_Challenges_2().Run();
                        break;
                    case "3":
                        Console.Clear();
                        new Code_Challenges_3().Run();
                        break;
                    case "4":
                        Console.Clear();
                        new Code_Challenges_4().Run();
                        break;
                    case "5":
                        Console.Clear();
                        new Code_Challenges_5().Run();
                        break;
                }
                break; // para di mag tuloy tuloy
            }

        }
    }

    class Code_Challenges_1
    {
        public void Run()
        {
            int firstInt;
            int secondInt;
            double firstdouble;
            double seconddouble;

            Displays.Display2intdoub();

            while (true)
            {
                Console.Write("\nEnter first integer: ");
                if (!int.TryParse(Console.ReadLine(), out firstInt)) // if the user input a letter
                {
                    Restrictions.InvalidInteger();
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("\nEnter second integer: ");
                if (!int.TryParse(Console.ReadLine(), out secondInt))
                {
                    Restrictions.InvalidInteger();
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("\nEnter first double: ");
                if (!double.TryParse(Console.ReadLine(), out firstdouble))
                {
                    Restrictions.InvalidDouble();
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("\nEnter second double: ");
                if (!double.TryParse(Console.ReadLine(), out seconddouble))
                {
                    Restrictions.InvalidDouble();
                    continue;
                }
                break;
            }

            int sumofint = firstInt + secondInt;
            double sumofdouble = firstdouble + seconddouble;
            double productof = sumofint * sumofdouble;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe sum of two integers is " + sumofint);
            Console.WriteLine("\nThe sum of two double is " + sumofdouble);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe product of the result (integer and double) is " + productof);
            Console.ResetColor();
        }

    }

    class Code_Challenges_2
    {
        public void Run()
        {
            string sentences;

            Displays.DisplayWordCount();

            Console.WriteLine("Enter a sentence:  ");
            sentences = Console.ReadLine();

            string[] words = sentences.Split(' ');

            int wordsCount = words.Length;

            Console.WriteLine("\nThe number of words in the sentence is: " + wordsCount);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe uppercase of the sentence: \n" + sentences.ToUpper());
            Console.ResetColor();
        }
    }

    class Code_Challenges_3
    {
        public void Run()
        {
            while (true)
            {
                double result = 0;
                string operation = "";

                Console.Clear(); //to clear the screen after the loop 

                Displays.DisplayCalculator();

                while (string.IsNullOrEmpty(operation) || !(operation == "+" || operation == "-" || operation == "*" || operation == "/"))
                {
                    Displays.DisplayArithmeticOperator();
                    Console.Write("Enter your arithmetic operator: ");
                    operation = Console.ReadLine();

                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        Restrictions.InvalidArithmeticOperator();
                        Displays.DisplayArithmeticOperator();
                        Console.Write("Enter your arithmetic operator: ");
                        operation = Console.ReadLine();
                    }
                }

                double valueFirst;
                double valueSecond;
                while (true)
                {
                    Console.Write("\nEnter the first value: ");
                    if (!double.TryParse(Console.ReadLine(), out valueFirst)) // if the user input a letter
                    {
                        Restrictions.InvalidInput();
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Write("\nEnter the second value: ");
                    if (!double.TryParse(Console.ReadLine(), out valueSecond)) // if the user input a letter
                    {
                        Restrictions.InvalidInput();
                        continue;
                    }
                    break;
                }

                switch (operation)
                {
                    case "+":
                        result = valueFirst + valueSecond;
                        break;
                    case "-":
                        result = valueFirst - valueSecond;
                        break;
                    case "*":
                        result = valueFirst * valueSecond;
                        break;
                    case "/":
                        if (valueSecond == 0)
                        {
                            Restrictions.InvalidDivision();
                            Console.Write("Enter your second value: ");
                            string secondval = Console.ReadLine();

                            if (!double.TryParse(secondval, out valueSecond))
                            {
                                Restrictions.InvalidInput();
                                return;
                            }
                            else
                            {
                                result = valueFirst / valueSecond;
                                break;
                            }
                        }
                        else
                        {
                            result = valueFirst / valueSecond;
                            break;
                        }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThe result is: " + result);
                Console.ResetColor();
                Console.ReadKey(); // to delay the the press 1 

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDo you want to perform another computation?");
                Console.ResetColor();

                Displays.DisplayToProceed();

                Console.Write("Enter your choice: ");
                string repeat = Console.ReadLine();

                if (repeat == "2")
                {
                    return; //terminate 
                }

                Console.ReadLine(); //used to pause the console output and wait for the user to press Enter before the console application is closed.
            }
        }
    }

    class Code_Challenges_4
    {
        public void Run()
        {
            double multiplier = 0;
            double multiplied = 0;

            Displays.DisplayMultiplicationTable();

            while (true)
            {
                Console.Write("Enter the number to be multiplied: ");
                if (!double.TryParse(Console.ReadLine(), out multiplied)) // if the user input a letter
                {
                    Restrictions.InvalidInteger();
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Enter the multiplier: ");
                if (!double.TryParse(Console.ReadLine(), out multiplier)) // if the user input a letter
                {
                    Restrictions.InvalidInteger();
                    continue;
                }
                break;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nMultiplication table for " + multiplied + ":\n");
            Console.ResetColor();

            for (int i = 1; i <= multiplier; i++)
            {
                Console.WriteLine(multiplied + " x " + i + " = " + (multiplied * i));
            }

        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }

    class Code_Challenges_5
    {
        public void Run()
        {
            Displays.Display5Cars();

            List<Car> cars = new List<Car>
            {
                new Car { Name = "Volvo", Model = "XC90", Year = "2022" },
                new Car { Name = "BMW", Model = "X5", Year = "2020" },
                new Car { Name = "Ford", Model = "Mustang", Year = "2018" },
                new Car { Name = "Mazda", Model = "CX-5", Year = "2021" },
                new Car { Name = "Audi", Model = "A4", Year = "2019" }
            };

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Original list of cars:");
            Console.ResetColor();
            DisplayCars(cars);

            // Sort the cars by year
            var sortedCars = cars.OrderBy(GetYear);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nSorted list of cars by year:");
            Console.ResetColor();
            DisplayCars(sortedCars.ToList());
        }

        // Method to extract the year from a Car object
        int GetYear(Car car)
        {
            return int.Parse(car.Year);
        }

        // Method to display list of cars
        void DisplayCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Name: {car.Name}, Model: {car.Model}, Year: {car.Year}");
            }

        }
    }


    class Displays
    {
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                  ");
            Console.WriteLine("            CODE CHALLENGES       ");
            Console.WriteLine("                                  ");
            Console.ResetColor();
        }

        public static void DisplayChoices()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                        ");
            Console.WriteLine("    PICK A CODE THAT YOU WANT TO RUN    ");
            Console.WriteLine("                                        ");
            Console.WriteLine("    1 : Two integers and two doubles    ");
            Console.WriteLine("    2 : Word count                      ");
            Console.WriteLine("    3 : Basic arithmetic functions.     ");
            Console.WriteLine("    4 : Multiplication table            ");
            Console.WriteLine("    5 : lIST                            ");
            Console.ResetColor();
        }

        public static void Display2intdoub()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                         ");
            Console.WriteLine("          TWO INTEGER & TWO DOUBLE       ");
            Console.WriteLine("                                         ");
            Console.ResetColor();
        }

        public static void DisplayWordCount()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                           ");
            Console.WriteLine("         WORD COUNT        ");
            Console.WriteLine("                           ");
            Console.ResetColor();
        }

        public static void DisplayCalculator()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                 ");
            Console.WriteLine("        CALCULATOR PROGRAM       ");
            Console.WriteLine("                                 ");
            Console.ResetColor();
        }

        public static void DisplayArithmeticOperator()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                               ");
            Console.WriteLine("      Arithmetic Operator:     ");
            Console.WriteLine("                               ");
            Console.WriteLine("            + : ADD            ");
            Console.WriteLine("            - : MINUS          ");
            Console.WriteLine("            * : TIMES          ");
            Console.WriteLine("            / : DIVIDE         ");
            Console.WriteLine("                               ");
            Console.ResetColor();
        }

        public static void DisplayToProceed()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                ");
            Console.WriteLine("        Press 1 to proceed      ");
            Console.WriteLine("        Press 2 to exit         ");
            Console.WriteLine("                                ");
            Console.ResetColor();
        }

        public static void DisplayMultiplicationTable()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                   ");
            Console.WriteLine("        MULTIPLICATION TABLE       ");
            Console.WriteLine("                                   ");
            Console.ResetColor();
        }

        public static void Display5Cars()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                  ");
            Console.WriteLine("          SORTED 5 CARS           ");
            Console.WriteLine("                                  ");
            Console.ResetColor();
        }
    }

    class Restrictions
    {
        public static void InvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("Please enter valid input again (numeric value).");
            Console.ResetColor();
        }

        public static void InvalidInteger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("Please enter a integer.");
            Console.ResetColor();
        }

        public static void InvalidDouble()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("Please enter a double.");
            Console.ResetColor();
        }

        public static void InvalidArithmeticOperator()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("INVALID INPUT: Please enter a valid arithmetic operator.");
            Console.ResetColor();
        }

        public static void InvalidDivision()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: Division by zero is not allowed.");
            Console.ResetColor();
        }

        public static void InvalidToProceed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: press 1 or 2");
            Console.ResetColor();
        }
    }


    class Entry_point
    {
        static void Main(string[] args)
        {
            Choices_Challenges Code = new Choices_Challenges(); //assigning which class starts the code

            do
            {
                Displays.DisplayHeader();
                Displays.DisplayChoices();
                Code.GetUserInput();

                while (true)
                {
                    Console.ReadKey();
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Do you want to go back to the main menu?");
                    Console.ResetColor();

                    Displays.DisplayToProceed();
                    Console.Write("\nEnter your choice: ");
                    string repeat = Console.ReadLine();

                    if (repeat != "1" && repeat != "2")
                    {
                        Restrictions.InvalidToProceed();
                        continue; // Continue the loop to ask for input again
                    }
                    else if (repeat == "2")
                    {
                        return; // Exit the loop if the user doesn't want to proceed
                    }
                    else
                    {
                        break; // Proceed to the next iteration if the user chooses to continue
                    }
                }
                Console.Clear();
            } while (true);
        }
    }
}