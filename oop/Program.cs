class Sorcerer //Base class (parent) 
 {

    //git
    //Attributes
    public string Ability;
    public string Grade;
    public string Name;

    //Encapsulation
    public string AbilityNew
    {
        get { return Ability; }
        set { Ability = value; }
    }

    public string GradeNew
    {
        get { return Grade; }
        set { Grade = value; }
    }

    public string NameNew
    {
        get { return Name; }
        set { Name = value; }
    }

    //Constructor
    public Sorcerer(string ability, string grade, string name) 
    {
        Ability = ability;
        Grade = grade;
        Name = name;
    }

    //Methods
    public virtual void Rank() 
    {
        Console.WriteLine("Congratulations! You have been promoted to Special Grade Sorcerer.");
    }

    public virtual void Race() 
    {
        Console.WriteLine("You use your powers for criminal purposes, therefore you are a Curse User.");
    }
}
//Inheritance: Creating a subclass for Sorcerer
class NonSorcerer : Sorcerer 
    {
//Constructor for the sub-class
public NonSorcerer(string ability, string grade, string name): base(ability, grade, name)
{
}

//Polymorphism: Override Rank Method
public override void Rank()
{
    Console.WriteLine("You don't possess any curse energy, but rankings are based on merits. Therefore you are promoted to Grade 4 Sorcerer!");
}
public override void Race()
{
    Console.WriteLine("You were born without any curse energy, therefore you are classified as a Non-Sorcerer.");
}
    }

class Program 
{
    static void Main(string[] args) 
    {
        Sorcerer jjSorcerer = new Sorcerer("Cursed Spirit Manipulation", "Special Grade", "Suguru Geto");
        Console.WriteLine($"Ability: {jjSorcerer.Ability}, Grade: {jjSorcerer.Grade}, Name: {jjSorcerer.Name}");
        jjSorcerer.Rank();
        jjSorcerer.Race();

        NonSorcerer diffRace = new NonSorcerer("Heaven Restrictrion", "Grade 4", "Maki Zenin");
        Console.WriteLine($"Ability: {diffRace.Ability}, Grade: {diffRace.Grade}, Name: {diffRace.Name}");
        diffRace.Rank();
        diffRace.Race();
    }
}
