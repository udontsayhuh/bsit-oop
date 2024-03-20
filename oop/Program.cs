using oop;

// Main Method
class Program {
    static void Main(string[] args) {
        //Player 1
        // Input: Name, Gender, Age, Favorite Hero, Favorite Hero Winrate, 
        Player p1 = new Player1(1, "Zynx", "Male", 20, "Fanny", 63.95); 
        p1.Information(); // print the Information
        p1.Status(); // online or offline
        p1.Do(); // in game or in queue

        Console.WriteLine(" ");

        //Player 2
        // Input: Name, Gender, Age, Favorite Hero, Favorite Hero Winrate, 
        Player p2 = new Player2(2, "Cyphra", "Female", 19, "Lylia", 55.67);
        p2.Information(); // print the Information
        p2.Status(); // online or offline
        p2.Do(); // in game or in queue

        Console.WriteLine(" ");

        //Player 3
        // Input: Name, Gender, Age, Favorite Hero, Favorite Hero Winrate, 
        Player p3 = new Player3(3, "Karl", "Male", 18, "Lancelot", 73.43);
        p3.Information(); // print the Information
        p3.Status(); // online or offline
        p3.Do(); // in game or in queue


    }
}
