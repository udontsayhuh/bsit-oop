
// Base class representing a hero
class Hero
{
    // attributes
    private string Ability;
    private string Rank;
    private string Name;

    // Encapsulation
    public string AbilityNew
    {
        get { return Ability; }
        set { Ability = value; }
    }

    public string RankNew
    {
        get { return Rank; }
        set { Rank = value; }
    }

    public string NameNew
    {
        get { return Name; }
        set { Name = value; }
    }

    // Constructor
    public Hero(string ability, string rank, string name)
    {
        Ability = ability;
        Rank = rank;
        Name = name;
    }

    // Method to display hero's details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {NameNew}, Ability: {AbilityNew}, Rank: {RankNew}");
    }

    // Abstraction: Method to perform hero's unique ability
    public virtual void PerformAbility()
    {
        Console.WriteLine($"{NameNew} performs {AbilityNew}! And it killed the enemy.");
    }
}

// Inheritance: Creating a subclass for hero
class NormalHero : Hero
{
    // Constructor for the subclass
    public NormalHero(string ability, string rank, string name) : base(ability, rank, name)
    {
    }

    // Polymorphism: Override PerformAbility method
    public override void PerformAbility()
    {
        Console.WriteLine($"{NameNew} attempts to perform {AbilityNew} And it destroys the building.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of a hero
        Hero saitama = new Hero("Serious Punch", "A-Class", "Saitama");
        saitama.DisplayDetails();
        saitama.PerformAbility();

        // Creating an instance of a hero
        NormalHero normalHero = new NormalHero("Fire Manipulation", "S-Class", "Genos");
        normalHero.DisplayDetails();
        normalHero.PerformAbility();
    }
}
