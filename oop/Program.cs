// Main Fuction
class Program {
    static void Main(string[] args) {
        Player p1 = new Player1("Zynx", 19, "Fanny");
        Console.WriteLine(Player1: p1.PlayerName);
        p1.Status();
        p1.Do();

    }
}

// Family Class
abstract class Player
{
    //Player Information
    private string playerName, heroName;
    private int playerAge;


    public abstract void Status();
    public abstract void Do();
    public string onlineStatus = "Online";
    public string offlineStatus = "Offline";
    public string inGame = "In Game";
    public string inQueue = "In Queue";

    //Getters and Setters 
    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerAge
    {
        get { return playerAge; }
        set { playerAge = value; }
    }
    public string HeroName
    {
        get { return heroName; }
        set { heroName = value; }
    }

    public Player(string playerName, int playerAge, string heroName)
    {
        PlayerName = playerName;
        PlayerAge = playerAge;
        HeroName = heroName;
    }

}

class Player1 : Player
{
    
    public Player1(string playerName, int playerAge, string heroName) : base(playerName, playerAge, heroName){}
    // Status
    public override void Status()
    {
        Console.WriteLine("Player 1 : " + onlineStatus);
    }
    // Do
    public override void Do()
    {
        Console.WriteLine("Player 1 is " + inQueue);
    }
}
