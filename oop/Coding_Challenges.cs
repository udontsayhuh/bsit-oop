using System;
using System.Collections;
class CodingChallenges
{
    static void Main(string[] args) 
    {
        //CHALLENGE I
        //~start~
        //Variable Declaration
        int inputInt_1, inputInt_2, sumInt;
        double inputDouble_1, inputDouble_2, convertedSum, sumDouble, sumsProduct;

        //Intro
        Console.WriteLine("\n     CHALLENGE I");

        //User Inputs
        Console.Write("\n\n Enter an Integer : ");
        inputInt_1 = Convert.ToInt32(Console.ReadLine());

        Console.Write(" Enter an Integer : ");
        inputInt_2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\n Enter a Double   : ");
        inputDouble_1 = Convert.ToDouble(Console.ReadLine());

        Console.Write(" Enter a Double   : ");
        inputDouble_2 = Convert.ToDouble(Console.ReadLine());

        //Calculations & Results
        sumInt = inputInt_1 + inputInt_2;
        Console.WriteLine("\n\n Integer Sum     : " + sumInt);
        convertedSum = Convert.ToDouble(sumInt);

        sumDouble = inputDouble_1 + inputDouble_2;
        Console.WriteLine(" Double Sum      : " + sumDouble);

        sumsProduct = convertedSum * sumDouble;
        Console.WriteLine(" Product         : " + sumsProduct);
        //~end~

        //Clear Screen
        Console.Write("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
        

        //CHALLENGE II
        //~start~

        //Intro
        Console.WriteLine("\n     CHALLENGE II");

        //User Input
        Console.Write("\n\n Enter a string      : ");
        string text = Console.ReadLine().ToUpper();

        string[] wordsNum = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int stringWords = wordsNum.Length;

        //Results
        Console.WriteLine("\n Number of words     : " + stringWords);
        Console.WriteLine(" String in uppercase : "+text);
        //~end~

        //Clear Screen
        Console.Write("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        //CHALLENGE III
        //~start~
        //Variable Declaration
        double num1, num2;
        string operatorOption, choice;

        //Intro
        Console.WriteLine("\n     CHALLENGE III");

        //Start again
        while (true)
        {
            while (true)
            {

            //User Input
            Console.Write("\n\n Enter an operator (+,-,*,/)   : ");
            operatorOption = Console.ReadLine();
            if (operatorOption != "+" && operatorOption != "-" && operatorOption != "*" && operatorOption != "/")
                {
                    Console.Write("\n Invalid! You must enter one of the given operators \n\n");
                }
                else
                {
                    break;
                }
            }

            Console.Write("\n Enter a number                : ");
            num1 = Convert.ToDouble(Console.ReadLine());
           
            Console.Write(" Enter a number                : ");
            num2 = Convert.ToDouble(Console.ReadLine());
            
            //Calculation & Result
            switch(operatorOption)
            {
                //Add
                case "+":
                Console.WriteLine("\n Result                        : " + (num1 + num2));
                break;

                //Subtract
                case "-":
                Console.WriteLine("\n Result                        : " + (num1 - num2));
                break;

                //Multiply
                case "*":
                Console.WriteLine("\n Result                        : " + (num1 * num2));
                break;

                //Divide
                case "/":
                Console.WriteLine("\n Result                        : " + (num1 / num2));
                break;
            }
            
            //Try again
            while (true)
            {
                Console.Write("\n\n Do you want to try again? (Yes/No): ");
                choice = Console.ReadLine().ToLower();
                if (choice == "no")
                {
                    break;
                }
                else if (choice == "yes")
                {
                    Console.WriteLine("\n\n");
                    break;
                }
                else
                {
                    Console.WriteLine(" Invalid! You must enter Yes or No");
                }
            }

            if (choice == "no")
            {
                break;
            }
            
        }
        //~end~
        
        //Clear Screen
        Console.Write("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        //CHALLENGE IV
        //~start~
        //Variable Declaration
        int baseNumber, multiplierNum, tableResult;

        //Intro
        Console.WriteLine("\n     CHALLENGE IV");
        
        //User Input
        Console.Write("\n\n Enter a number       : ");
        baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write(" Enter the multiplier : ");
        multiplierNum = Convert.ToInt32(Console.ReadLine());

        //Result
        Console.WriteLine("\n Multiplication Table of " + (baseNumber) + " from 1 to " + (multiplierNum));
        //Calculation
        for (int i = 1; i <= multiplierNum; i++)
        {
            tableResult = baseNumber * i;
            Console.WriteLine(" " + (baseNumber) + " * " + (i) + " = " + (tableResult));
        }
        //~end~
        
        //Clear Screen
        Console.Write("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        //CHALLENGE V
        //~start~

        //Intro
        Console.WriteLine("\n     CHALLENGE V");

        Console.WriteLine("\n\n Enter 5 Cars");       
        ArrayList Cars = new ArrayList();

        for (int j = 0; j < 5; j++)
        {
            Console.Write(" Car #" + (j + 1) + ": ");
            string inputCars = Console.ReadLine();
            Cars.Add(inputCars);
        }

        Console.WriteLine("\n\n Cars:");
        PrintList(Cars);

        
        Cars.Sort();
        Console.WriteLine("\n Cars(Sorted):");
        PrintList(Cars);
        //~end~

        //Clear Screen
        Console.Write("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

        //Outro
        Console.WriteLine("\n     All Challenges Finished");
        Console.WriteLine("           ~THE END~       ");
    }

    static void PrintList(ArrayList array)
    {
        foreach (var input in array)
        {
            Console.WriteLine(" " + (input));
        }
    }
}
