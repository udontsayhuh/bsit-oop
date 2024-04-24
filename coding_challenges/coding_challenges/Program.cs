using System;


namespace CodingChallenges
{
    class SumOfIntegerDouble
    {

        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

    }
    class StringCounter
    {
        public int WordCounter(string str)
        {
            // Split the string into words based on whitespace
            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }

        public string Capitalize(string str)
        {
            return str.ToUpper();
        }
    }

    class ArithmeticMethods
    {
        // Method for addition 
        public double Add(double x, double y)
        {
            return x + y;
        }

        // Method for subtraction 
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        // Method for multiplication 
        public double Multiply(double x, double y)
        {
            return x * y;
        }


        // Method for division
        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return x / y;
        }
    }
    class MultiplicationTable
    {
        public void CreateTable(int x, int y) // x is multiplier, y is multiplied
        {
            for (int i = 1; i <= y; i++)
            {
                int result = x * i;
                Console.WriteLine(x + " * " + i + " = " + result);
            }
        }
    }

    class DisplaySortedList
    {
        public void displayCars()
        {
            // Create an array to store cars
            string[] cars = new string[5];

            // Add 5 cars to the array
            cars[0] = "Mitsubishi";
            cars[1] = "Honda";
            cars[2] = "Toyota";
            cars[3] = "Peugeot";
            cars[4] = "Geely";

            // Display the original list of cars
            Console.WriteLine("Original list of cars:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            // Sort the array
            Array.Sort(cars);

            // Display the sorted list of cars
            Console.WriteLine("\nSorted list of cars:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
    class Program
    {


        int menu()
        {
            int choice;
            Console.WriteLine("Menu for Code Challenges");
            Console.WriteLine("\n[1] Sum of Integer and Double");
            Console.WriteLine("\n[2] String Word Count and Capitalization ");
            Console.WriteLine("\n[3] Basic Arithmetic Methods ");
            Console.WriteLine("\n[4] Multiplication Table");
            Console.WriteLine("\n[5] Display Sorted list");
            Console.WriteLine("\n[6] Exit");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Enter your choice:");
           
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return choice;
        }
       
        
        static void Main(string[] args)
        {
            Program prog = new Program();
            SumOfIntegerDouble sid = new SumOfIntegerDouble(); // instance of class SumOfIntegerDouble class
            StringCounter strct = new StringCounter(); // instance of class StringCounter class
            ArithmeticMethods arith = new ArithmeticMethods();
            MultiplicationTable table = new MultiplicationTable();
            DisplaySortedList cars = new DisplaySortedList();
            //variables can be used
            int a, b,res1;
            double x, y,res2, result;
            string input;
            // my indicator to avoid mixing

            while (true)
            {
                switch (prog.menu()){       //switch case for returned value from menu() in class Program
                    case 1:
                        Console.Clear();        //clears the screen (in terminal/output)
                        
                        Console.WriteLine("\tCoding Challenge 1");
                        Console.WriteLine("\tAddition mode (int and double)");
                        Console.WriteLine("Adding 2 Integer Numbers");
                        Console.Write("\nEnter First Number to add: ");
                        while (!int.TryParse(Console.ReadLine(), out a))            //data validation if the number entered is not integer
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.WriteLine("Enter First Number to add:"); 
                        }
                        Console.Write("\nEnter Second Number to add:");
                        while(!int.TryParse(Console.ReadLine(), out b))            //data validation if the number entered is not integer
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.WriteLine("Enter Second Number to add:");
                        }
                        res1 = sid.Add(a, b);
                        Console.WriteLine("\nResult for adding 2 Integers: " + res1);       //variable a + b (integers)
                        Console.WriteLine("\n\tAdding 2 Double Numbers");
                        Console.Write("\nEnter First Number to add:");
                        while (!double.TryParse(Console.ReadLine(), out x))       //data validation if the number entered is not double
                        {
                            Console.WriteLine("Invalid input. Please enter a valid double number.");
                            Console.WriteLine("Enter First Number to add:");
                        }
                        Console.Write("\nEnter Second Number to add:");
                        while (!double.TryParse(Console.ReadLine(), out y))       //data validation if the number entered is not double
                        {
                            Console.WriteLine("Invalid input. Please enter a valid double number.");
                            Console.WriteLine("Enter Second Number to add:");
                        }
                        res2 = sid.Add(x, y);           //calling overrided method add() , the double in parameter
                        Console.WriteLine("Result for adding 2 Doubles: " + res2.ToString("0.00"));
                        result = sid.Add(res1, res2);           // adding 2 results, the result for integer and double
                        Console.WriteLine(res1 + " + " + res2 + " is equal to " + result.ToString("0.00"));   // displays the result in 2 decimal points. e.g. 2.75
                        Console.ReadKey(); // blocker, like getch()
                        Console.Clear(); // like cls in command, clear screen
                        break;
                    case 2:
                        Console.Clear();        //clear screen
                        Console.WriteLine("String Counter and Capitalization");
                        Console.Write("\nEnter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine("There are " + strct.WordCounter(input) + " words in the string"); //displaying how many word in a string entered by user
                        Console.WriteLine("Capitalized : " + strct.Capitalize(input));      // capitalization is called to display uppercased string
                        Console.ReadKey(); // like getch();
                        break;

                    case 3:
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Arithmetic Methods");
                            Console.WriteLine("[+] Addition");
                            Console.WriteLine("[-] Subtraction");
                            Console.WriteLine("[/] Division");
                            Console.WriteLine("[*] Multiplication");
                            Console.Write("\nChoose an operator [ + , - , / , *] :");
                            ConsoleKeyInfo keyInfo = Console.ReadKey();
                            char c = keyInfo.KeyChar;

                            switch (c)
                            {
                                case '+':
                                    Console.Write("\nEnter the first value: ");
                                    while (!double.TryParse(Console.ReadLine(), out x))       //data validation if the number entered is not double
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                        Console.WriteLine("Enter Second Number to add:");
                                    }
                                    Console.Write("\nEnter the Second value: ");
                                    while (!double.TryParse(Console.ReadLine(), out y))       //data validation if the number entered is not double
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                        Console.WriteLine("Enter Second Number to add:");
                                    }
                                    result = arith.Add(x, y);
                                    Console.WriteLine("The sum of " + x + " and " + y + " is equal to " + result);
                                    break;
                                case '-':
                                    Console.Write("\nEnter the first value: ");
                                    while (!double.TryParse(Console.ReadLine(), out x))
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                        Console.WriteLine("Enter Second Number to add:");
                                    }
                                    Console.Write("\nEnter the Second value: ");
                                    while (!double.TryParse(Console.ReadLine(), out y))       //data validation if the user enters a non-numeric 
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                        Console.WriteLine("Enter Second Number to add:");
                                    }
                                    result = arith.Subtract(x, y);
                                    Console.WriteLine("The difference of " + x + " and " + y + " is equal to " + result);
                                    break;
                                case '/':
                                    Console.Write("\nEnter the first value: ");
                                    while (!double.TryParse(Console.ReadLine(), out x))       //data validation if the number entered is not double
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                        Console.WriteLine("Enter Second Number to add:");
                                    }
                                    Console.Write("\nEnter the Second value: ");
                                    while (!double.TryParse(Console.ReadLine(), out y))       //data validation if the number entered is not double
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                        Console.WriteLine("Enter Second Number to add:");
                                    }
                                    result = arith.Divide(x, y);
                                    Console.WriteLine("The quotient of " + x + " and " + y + " is equal to " + result);
                                    break;
                                case '*':
                                    Console.Write("\nEnter the first value: ");
                                    while (!double.TryParse(Console.ReadLine(), out x))       //data validation if the number entered is not double
                                    {
                                        Console.WriteLine("Invalid input. Please enter a  number.");
                                        Console.WriteLine("Enter Second Number to add:");
                                    }
                                    Console.Write("\nEnter the Second value: ");
                                    while (!double.TryParse(Console.ReadLine(), out y))       //data validation if the number entered is not double
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                        Console.WriteLine("Enter Second Number to add:");
                                    }
                                    result = arith.Multiply(x, y);
                                    Console.WriteLine("The product of " + x + " and " + y + " is equal to " + result);
                                    break;
                                default:
                                    Console.WriteLine("Invalid Operator! Try again...");
                                    Console.Clear();
                                    break;
                            }
                            Console.WriteLine("Do you want to perform another action? Y for YES, N for NO");
                            input = Console.ReadLine();
                            if (input.ToLower() == "y")
                            {
                                // Continue the loop to perform another action
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        }
                            break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Multiplication Table");
                        Console.Write("\nEnter a multiplier: ");
                        a = Convert.ToInt32(Console.ReadLine()); // converts into integer and reads the value prompted by user and passed in int a

                        Console.Write("\nEnter a multiplied number: ");
                        b = Convert.ToInt32(Console.ReadLine()); // converts into integer and reads the value prompted by user and passed in int b
                        table.CreateTable(a, b);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\tDisplays Sorted List");
                        cars.displayCars();     //calls the displayCars() method
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("\nThank you for using my program :)");
                        Environment.Exit(0);        // like exit(0)
                        break;
                    default:
                        Console.WriteLine("Invalid Entry, Try Again!!");
                        break;
                }
            }

            }
        }
    



}




