using System;

public class CodingChallenges {
    public static void Main(string[] args) {
        while (true) {
            Console.Clear();
            Console.WriteLine("  _______________________________");
            Console.WriteLine(" /////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine("|          Coding Challenges      |");
            Console.WriteLine("|  1. Product of Sums             |");
            Console.WriteLine("|  2. Word Counter                |");
            Console.WriteLine("|  3. Simple Calculator           |");
            Console.WriteLine("|  4. Multiplication Table        |");
            Console.WriteLine("|  5. String Sorter               |");
            Console.WriteLine("|  6. Main Menu                   |");
            Console.WriteLine(" _________________________________");
            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice)) {
                Console.WriteLine("Error: Invalid input. Please enter an integer between 1 and 6.");
                continue;
            }
            switch(choice) {
                case 1:
                    Console.Clear();
                    ProductOfSumsProgram.Main(args);
                    GoBackToCodingChallengesMenu();
                    break;
                case 2:
                    Console.Clear();
                    WordCounterProgram.Main(args);
                    GoBackToCodingChallengesMenu();
                    break;
                case 3:
                    Console.Clear();
                    SimpleCalculatorProgram.Main(args);
                    GoBackToCodingChallengesMenu();
                    break;
                case 4:
                    Console.Clear();
                    MultiplicationTableProgram.Main(args);
                    GoBackToCodingChallengesMenu();
                    break;
                case 5:
                    Console.Clear();
                    StringSorterProgram.Main(args);
                    GoBackToCodingChallengesMenu();
                    break;
                case 6:
                    GoBackToMainMenu();
                    return;
                default:
                    Console.WriteLine("Error: Invalid input. Please enter an integer between 1 and 5.");
                    break;
            }
        }
    }

    static void GoBackToCodingChallengesMenu() {
        Console.Write("\nPress Enter to go back to Coding Challenges Menu... ");
        Console.ReadLine();
    }

    static void GoBackToMainMenu() {
        Console.Write("\nPress Enter to go back to Main Menu... ");
        Console.ReadLine();
    }
}
