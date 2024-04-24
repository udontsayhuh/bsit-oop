using System;

namespace oop
{
    class Coding_Challenges
    {
        static void Main(string[] args)
        {
            // Question no. 1
            Console.Write("Coding Challenge No. 1");
            Console.Write("\nEnter a first number: ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            
            // Perform integer addition.
            Console.Write("Enter a second number: ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            // Perform decimal addition.
            Console.Write("\nEnter a first decimal number: ");
            double firstDecimal = Convert.ToDouble(Console.ReadLine());

            // Calculate product of sum of integers and sum of decimals.
            Console.Write("Enter a second decimal number: ");
            double secondDecimal = Convert.ToDouble(Console.ReadLine());

            int sum = firstInteger + secondInteger;
            Console.Write($"\n{firstInteger} + {secondInteger} = {sum}");

            double sumOfDouble = firstDecimal + secondDecimal;
            Console.Write($"\n{firstDecimal} + {secondDecimal} = {sumOfDouble}");

            double product = sum * sumOfDouble;
            Console.Write($"\n{sum} * {sumOfDouble} = {product}");

            // Question no. 2
            Console.Write("\n\nCoding Challenge No. 2");
            Console.Write("\nEnter a string: ");
            string input = Console.ReadLine();

            // Calculate length of the input string.
            int length = input.Length;
            // Convert input string to uppercase.
            string upper = input.ToUpper();
            // Display the length.
            Console.Write($"Lenght: {length}");
            // Display the input string converted to uppercase.
            Console.Write($"\nConverted string to uppercase: {upper}");

            // Question no. 3
            Console.Write("\n\nCoding Challenge No. 3");
            // Loop until the user decides not to try again.
            bool tryAgain = true;
            while (tryAgain)
            {
                // Prompt the user for the first, second number, and operation.
                Console.Write("\nEnter a first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter an operation: ");
                string operation = Console.ReadLine();

                int result = 0;
                // Switch-case statement
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        break;

                    case "*":
                        result = firstNumber * secondNumber;
                        break;

                    case "/":
                        result = firstNumber / secondNumber;
                        break;

                    default:
                        Console.WriteLine("Invalid Result");
                        break;

                }
                // Print the result of the operation.
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
                // Prompt the user if they want to perform another operation.
                Console.Write("\nDo you want to perform again? (Yes or No): ");

                // Set the tryAgain variable based on user input.
                string tryAgainInput = Console.ReadLine();
                tryAgain = tryAgainInput == "Yes"; // Set tryAgain to true if user input is "Yes".
            }

            // Question no. 4
            // Prompts the user to enter number to be multiplied and multiplier.
            Console.WriteLine("\n\nCoding Challenge No. 4");
            Console.Write("Enter the number to be multiplied: ");
            int numberToBeMultiplied = int.Parse(Console.ReadLine());

            Console.Write("Enter the multiplier: ");
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication Table: ");
            // Iterate from 1 to the specified number to be multiplied. 
            for (int i = 1; i <= numberToBeMultiplied; i++)
            {
                // Calculate the product and display it.
                int products = numberToBeMultiplied * i;
                Console.WriteLine($"{numberToBeMultiplied} x {i} = {products}\n");
            }

            // Question No. 5
            Console.WriteLine("\n\nCoding Challenge No. 5");
            // A list to store car names.
            List<string> cars = new List<string>();

            // Add cars to the list.
            cars.Add("Tesla");
            cars.Add("Ferrari");
            cars.Add("Lamborghini");
            cars.Add("BMW");
            cars.Add("Ford");

            // Print the original list of cars.
            Console.WriteLine("Original list: ");
            DisplayCars(cars);

            // Sort the list of cars.
            cars.Sort();

            // Print the sorted list of cars.
            Console.WriteLine("Sorted List: ");
            DisplayCars(cars);
        }
        static void DisplayCars(List<string> cars)
        {
            // Iterate through each car in the list and print it.
            foreach(string car in cars)
                Console.WriteLine(car);
            Console.WriteLine();
        } 
    }
}