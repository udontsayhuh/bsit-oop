using Coding_Challenges;
using System;

namespace CodingChallenges
{
    class CodingChallenges
    {
        static void Main(string[] args)
        {
            DisplayCodingChallenges();
        }

        // a method that displays the list of coding challenges
        static void DisplayCodingChallenges()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("  List of Coding Challenges: ");
            Console.WriteLine("--------------------------------------------------\n");
            Console.WriteLine("1. Sum of two integers and two doubles separately");
            Console.WriteLine("2. Count the number of words in a string");
            Console.WriteLine("3. Performing basic arithmetic functions");
            Console.WriteLine("4. Multiplication table of a given number");
            Console.WriteLine("5. Sorting a list");

            while (true)
            {
                again: // goto statement will go here if input is invalid

                Console.Write("\nEnter your option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        TryAgain();
                        break;
                    case "2":
                        CountWords countWords = new CountWords();
                        countWords.UserInputString();
                        TryAgain();
                        break;
                    case "3":
                        Arithmetic arithmetic = new Arithmetic();
                        arithmetic.DisplayArithmeticOperations();
                        TryAgain();
                        break;
                    case "4":
                        MultiplicationTable multiplicationTable = new MultiplicationTable();
                        multiplicationTable.InputNumbers();
                        TryAgain();
                        break;
                    case "5":
                        SortingList sortlist = new SortingList();
                        sortlist.Sort();
                        TryAgain();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Choose a number from 1 to 5. Try again!");
                        goto again;
                }
            }
        }

        // a method that will ask if user wants to try again
        static void TryAgain()
        {
            while (true)
            {
                Console.Write("\nReturn to main menu? (yes/no): ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "yes")
                {
                    Console.Clear();
                    DisplayCodingChallenges();
                    break;
                }
                else if (choice == "no")
                {
                    Console.WriteLine("\nExiting program...");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }
    }

}
