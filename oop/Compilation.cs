using System;

class Compilation {
    static void Main(string[] args) {
        while (true) {
            Console.Clear();
            Console.WriteLine("  _______________________________");
            Console.WriteLine(" /////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine("|             Main Menu!          |");
            Console.WriteLine("|  1. Run Program                 |");
            Console.WriteLine("|  2. Run Calculator              |");
            Console.WriteLine("|  3. Run Coding Challenges       |");
            Console.WriteLine("|  4. Exit                        |");
            Console.WriteLine(" _________________________________");
            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice)) {
                Console.WriteLine("Error: Invalid input. Please enter an integer between 1 and 4.");
                continue;
            }

            switch (choice) {
                case 1:
                    Console.Clear();
                    Program.Main(args);
                    GoBackToMainMenu();
                    break;
                case 2:
                    Console.Clear();
                    CalculatorApp.Main(args);
                    GoBackToMainMenu();
                    break;
                case 3:
                    CodingChallenges.Main(args);
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the program!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter an integer between 1 and 4.");
                    break;
            }
        }
    }

    static void GoBackToMainMenu() {
        Console.Write("\nPress Enter to go back to Main Menu... ");
        Console.ReadLine();
    }
}
