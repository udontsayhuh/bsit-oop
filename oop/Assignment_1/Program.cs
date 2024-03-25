/*using oop.Assignment_1;

// Main Method
class Program {
    static void Main(string[] args) {
        double val = 12.00;

        string displayed_value = val.ToString("N0");
        Console.WriteLine(val);

        // ACTIVITY 1
        // Player 1
        // Input: Name, Gender, Age, Favorite Hero, Favorite Hero Winrate, 
        Player p1 = new Player1(1, "Zynx", "Normal", "Male", 20, "Fanny", 64.30); 
        p1.normalPlayerInformation(); // print the Information
        p1.Status(); // online or offline
        p1.Do(); // in game or in queue

        Console.WriteLine(" ");

        // Player 2
        // Input: Name, Gender, Age, Favorite Hero, Favorite Hero Winrate, 
        Player p2 = new Player2(2, "Cyphra", "Normal", "Female",  19, "Lylia", 55.67);
        p2.normalPlayerInformation(); // print the Information
        p2.Status(); // online or offline
        p2.Do(); // in game or in queue

        Console.WriteLine(" ");

        // Player 3
        // MPL Player
        // Input: Name, Gender, Age, Favorite Hero, Favorite Hero Winrate, 
        Player3 p3 = new Player3(3, "Karl", "MPL Player", 5, "Male", 18, "Lancelot", 73.43);
        p3.professionalPlayerInformation(); // print the Information
        p3.Status(); // online or offline
        p3.Do(); // in game or in queue

        // Include if the terminal is automatically closing
        /*Console.WriteLine("\nPress enter to close...");
        Console.ReadKey();

    }
}*/
