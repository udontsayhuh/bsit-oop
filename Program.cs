class Music
{
    //Encapsulation: Making attributes public
    //Attributes
    public string Song;
    public string Artist;

    //Constructor
    public Music(string song, string artist)
    {
        Song = song;
        Artist = artist;
    }
    // Abstraction: Implementing methods that can be overridden by subclasses.
    //Methods
    public virtual void Play()
    {
        Console.WriteLine("Relax now, The music is playing.\n");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The music has stopped playing.\n");
    }
}//Inheritance: 
class Instrumental: Music
{
    //Constructor
    public Instrumental(string song, string artist) : base(song, artist) { }

    //Polymorphism: Ovveriding method
    public override void Play()
    { 
        Console.WriteLine("The Instrumental Music is now playing.\n");
    }
    public override void Stop()
    {
        Console.WriteLine("The Instrumental Music has now stopped.\n");
    }
}
   
class Program
{
    static void Main(string[] args)
    {
        Music myPlaylist = new Music("Para sa Streets", "Hev Abi");
        Console.WriteLine($"Song: {myPlaylist.Song}, Artist: {myPlaylist.Artist}");
        myPlaylist.Play();
        myPlaylist.Stop();

        Instrumental myInstrumental = new Instrumental("A Thousand Years", "The Piano Guys");
        Console.WriteLine($"Song: {myInstrumental.Song}, Artist: {myInstrumental.Artist}");
        myInstrumental.Play();
        myInstrumental.Stop();

    }
}
