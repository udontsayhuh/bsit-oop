using System;

// Base class demonstrating Inheritance and Abstraction
abstract class Vehicle {
    // Encapsulated attributes
    private string name;
    private string model;
    private int year;

    // Properties to access encapsulated attributes
    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string Model {
        get { return model; }
        set { model = value; }
    }

    public int Year {
        get { return year; }
        set { year = value; }
    }

    // Abstract method demonstrating Abstraction
    public abstract void StartEngine();
}

// Derived class demonstrating Inheritance and Polymorphism
class Car : Vehicle {
    // Additional attributes
    private string number;
    private int speed;
    private int winsRace;
    private int firstMovieRelease;

    // Constructor
    public Car(string name, string make, int year, string number, int speed, int winsRace, int firstMovieRelease) {
        Name = name;
        Model = make; // Assigning 'make' to 'Model' for consistency
        Year = year;
        this.number = number;
        this.speed = speed;
        this.winsRace = winsRace;
        this.firstMovieRelease = firstMovieRelease;
    }

    // Method overriding demonstrating Polymorphism
    public override void StartEngine() {
        Console.WriteLine($"Starting {Name}'s engine.");
    }

    // Methods
    public void Drive() {
        Console.WriteLine($"The {Name} with number {number} is now running at {speed} mph.");
    }

    public void Stop() {
        Console.WriteLine($"The {Name} with number {number} has stopped.");
    }

    // Additional methods to access and update winsRace and firstMovieRelease
    public int WinsRace {
        get { return winsRace; }
        set { winsRace = value; }
    }

    public int FirstMovieRelease {
        get { return firstMovieRelease; }
        set { firstMovieRelease = value; }
    }
}

class Program {
    static void Main(string[] args) {
        Car mcQueen = new Car("Lightning McQueen", "Chevrolet", 2006, "95", 200, 7, 2006);
        mcQueen.Model = "C6 Chevrolet Corvette"; // Updating the model
        Console.WriteLine("Name: " + mcQueen.Name);
        Console.WriteLine("Model: " + mcQueen.Model);
        Console.WriteLine("Movie Year: " + mcQueen.FirstMovieRelease);
        Console.WriteLine();
        mcQueen.StartEngine(); // Polymorphic behavior
        mcQueen.Drive();
        mcQueen.Stop();
    }
}
