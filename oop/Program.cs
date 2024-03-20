using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Drama
        Webtoon dramaSeries = new DramaSeries(
            "Drama",
            "Dear Nemesis",
            "Velma/ohsso",
            "\nCalmia Phlox is given a second chance at life, \n" +
            "but this time, she must compete against her beloved \n" +
            "twin brother to gain back her coveted status and title\n" +
            "as Countess Phlox. What’s more, her nemesis wants to... \n" +
            "marry her?! Striking a deal with her former archenemy, \n" +
            "Rudbeckia, while struggling between her ambitions and her \n" +
            "fondness for her brother, will Calmia reclaim what is hers?",
            "Monday",
            1
            );
        dramaSeries.displayDramaSeries();

        //Romance
        Webtoon romanceSeries = new RomanceSeries(
            "Romance",
            "For My Derelict Favorite",
            "Kim Seonyu/Ryuho",
            "\nWhat happens after the story ends with a \n" +
            "“happily ever after”? When Hestia enters her \n" +
            "favorite novel as a side character, she happily \n" +
            "fangirls from the sidelines. Thinking she’ll \n" +
            "return home when the story reaches its end, \n" +
            "Hestia finds that the only thing awaiting her is \n" +
            "the tragic death of her favorite character. \n" +
            "Now miraculously restored to the day of the ending, \n" +
            "Hestia decides that she’ll no longer spectate from the \n" +
            "sidelines – instead, she’ll save her derelict favorite!",
            "Saturday",
            64
            );
        romanceSeries.displayRomanceSeries();


    }
}

//Encapsulation
abstract class Webtoon
{
    //private
    private string genre;
    private string title;
    private string author;
    private string description;
    private string updateDay;
    private int episode;

    //public
    public string Genre
    {
        get => genre; 
        set => genre = value;
    }
    public string Title
    {
        get => title; 
        set => title = value;
    }
    public string Author
    {
        get => author; 
        set => author = value;
    }
    public string Description
    {
        get => description; 
        set => description = value;
    }
    public string UpdateDay
    {
        get => updateDay;
        set => updateDay = value;
    }
    public int Episode
    {
        get => episode; 
        set => episode = value;
    }

    //Abstraction
    public abstract void displaySeries();
    public abstract void displayCurrentEpisode();
    public abstract void displayNextEpisode();

    //Constructor
    public Webtoon(string genre, string title, string author, 
        string description, string updateDay, int episode)
    {
        Genre = genre;
        Title = title;
        Author = author;
        Description = description;
        Episode = episode;
        UpdateDay = updateDay;  
    }

    public void displayDramaSeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine(" ");
        Console.WriteLine("Description: " + Description);
        Console.WriteLine(" ");
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public void displayRomanceSeries()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine(" ");
        Console.WriteLine("Description: " + Description);
        Console.WriteLine(" ");
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public void displayThrillerSeries()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine(" ");
        Console.WriteLine("Description: " + Description);
        Console.WriteLine(" ");
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public void displayFantasySeries()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine(" ");
        Console.WriteLine("Description: " + Description);
        Console.WriteLine(" ");
        Console.WriteLine("Updates every: " + UpdateDay);
    }
}

//Inheritance
class DramaSeries : Webtoon
{
    public DramaSeries (string genre, string title, string author,
        string description, string updateDay, int episode) : base(genre, title, author, 
            description, updateDay, episode)
    {

    }
    public override void displaySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public override void displayCurrentEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Episode " + Episode);
    }
}

//Inheritance2
class RomanceSeries : Webtoon
{
    public RomanceSeries(string genre, string title, string author,
        string description, string updateDay, int episode) : base(genre, title, author,
            description, updateDay, episode)
    {

    }
    public override void displaySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public override void displayCurrentEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Episode " + Episode);
    }
}
//Inheritance3
class ThrillerSeries : Webtoon
{
    public ThrillerSeries(string genre, string title, string author,
        string description, string updateDay, int episode) : base(genre, title, author,
            description, updateDay, episode)
    {

    }
    public override void displaySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public override void displayCurrentEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Episode " + Episode);
    }
}
//Inheritance4
class FantasySeries : Webtoon
{
    public FantasySeries(string genre, string title, string author,
        string description, string updateDay, int episode) : base(genre, title, author,
            description, updateDay, episode)
    {

    }
    public override void displaySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public override void displayCurrentEpisode()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Episode " + Episode);
    }
}
