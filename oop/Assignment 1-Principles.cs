using System.Security.Cryptography.X509Certificates;

/*class Program
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
            78,
            79
            );

        dramaSeries.displayDramaSeries();
        dramaSeries.displayCurrentEpisode();
        dramaSeries.displayNextEpisode();

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
            65,
            66
            );

        romanceSeries.displayRomanceSeries();
        romanceSeries.displayCurrentEpisode();
        romanceSeries.displayNextEpisode();

        //Thriller
        Webtoon thrillerSeries = new ThrillerSeries(
            "Thriller",
            "It's Mine",
            "LuckS",
            "\nThere’s nothing that Yohan Do doesn’t \n" +
            "know about his crush, Dajeong. Where she \n" +
            "sits in class, works after school... and even \n" +
            "where she lives. But unable to approach her, \n" +
            "he watches her every move from afar and will \n" +
            "do anything to protect her. Anything.",
            "Friday",
            156,
            157
            );

        thrillerSeries.displayThrillerSeries();
        thrillerSeries.displayCurrentEpisode();
        thrillerSeries.displayNextEpisode();

        //Fantasy
        Webtoon fantasySeries = new FantasySeries(
            "Fantasy",
            "I'm the Queen in This Life",
            "Themis/Omin",
            "\nThe Etruscan Kingdom is stained with blood when \n" +
            "the king’s illegitimate son Cesare conspires with his \n" +
            "fiancée Ariadne to usurp the throne from his half-brother \n" +
            "Alfonso. Despite Ariadne’s devotion to the new king, her faith \n" +
            "is shattered when she is betrayed by him and eventually murdered \n" +
            "by her own sister, who wishes to be queen. To her surprise, \n" +
            "Ariadne finds herself sent back in time to her 17-year-old self. \n" +
            "As she navigates the perils and opportunities of palace intrigue, \n" +
            "Ariadne must make the most of her guile and grit to ensure that her \n" +
            "tragic future does not repeat itself.",
            "Monday",
            49,
            50
            );

        fantasySeries.displayThrillerSeries();
        fantasySeries.displayCurrentEpisode();
        fantasySeries.displayNextEpisode();
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
    private int nextEpisode;

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
    public int NextEpisode
    {
        get => nextEpisode;
        set => nextEpisode = value;
    }

    //Abstraction
    public abstract void displaySeries();
    public abstract void displayCurrentEpisode();
    public abstract void displayNextEpisode();

    //Constructor
    public Webtoon(string genre, string title, string author, 
        string description, string updateDay, int episode, int nextEpisode)
    {
        Genre = genre;
        Title = title;
        Author = author;
        Description = description;
        Episode = episode;
        UpdateDay = updateDay;
        NextEpisode = nextEpisode;
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

//InheritanceDrama
class DramaSeries : Webtoon
{
    public DramaSeries (string genre, string title, string author,
        string description, string updateDay, int episode, int nextEpisode) : base(genre, title, author, 
            description, updateDay, episode, nextEpisode)
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
        Console.WriteLine("Current Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Next Episode " + NextEpisode);
    }
}

//InheritanceRomance
class RomanceSeries : Webtoon
{
    public RomanceSeries(string genre, string title, string author,
        string description, string updateDay, int episode, int nextEpisode) : base(genre, title, author,
            description, updateDay, episode, nextEpisode)
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
        Console.WriteLine("Current Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Next Episode " + NextEpisode);
    }
}
//InheritanceThriller
class ThrillerSeries : Webtoon
{
    public ThrillerSeries(string genre, string title, string author,
        string description, string updateDay, int episode, int nextEpisode) : base(genre, title, author,
            description, updateDay, episode, nextEpisode)
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
        Console.WriteLine("Current Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Next Episode " + NextEpisode);
    }
}
//InheritanceFantasy
class FantasySeries : Webtoon
{
    public FantasySeries(string genre, string title, string author,
        string description, string updateDay, int episode, int nextEpisode) : base(genre, title, author,
            description, updateDay, episode, nextEpisode)
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
        Console.WriteLine("Current Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Next Episode " + NextEpisode);
    }
}*/
