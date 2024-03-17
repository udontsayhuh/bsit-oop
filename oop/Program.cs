using System;
class Car { // Create class called Car. This is the Parent class as well.

    // Create Encapsulation attributes with public access modifiers.
    public string Model;
    public string Make;
    public int Year;

    // Create Encapsulation attributes with private access modifiers.
    private string _registeredOwner;

    // Create a constructor with multiple parameters to initialize the value.
    public Car(string model, string make, int year, string registeredOwner) {
        Model = model;
        Make = make;
        Year = year;
        _registeredOwner = registeredOwner;
    }

    // Encapsulation property for _registeredOwner
    public string Registered_owner {
        get { return _registeredOwner; }     // get method will return the value of variable _registeredOwner.
        set { _registeredOwner = value; }    // set method will assign the value to the _registeredOwner variable.
    }

    // Create methods
    public void Drive() {
        Console.WriteLine($"The car is now running.");
    }

    public virtual void Speed(string speed) {   // Polymorphism. This method can be overriden by child classes.
        Console.WriteLine($"The car is moving at the {speed} speed!");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.\n");
    }
}

// Create Inheritance. Child class.
class PoliceCar : Car {
    public PoliceCar(string model, string make, int year, string registeredOwner) : base(model, make, year, registeredOwner) { }


    public override void Speed(string speed) {  // Polymorphism. Overrides the Speed method from the parent class.
        base.Speed($"{speed}");
    }
}

// Create an abstract class. Inheret from Car.
abstract class SoundSystem : Car {
    public bool IsOn;
    public bool IsNotPaused;
    public int Volume;

    public SoundSystem(string model, string make, int year, string registeredOwner) : base(model, make, year, registeredOwner) { }

    // Abstract method without body.
    public abstract void SoundPowerButton(bool IsOn);
    public abstract void VolumeLevel(int vol_level);
    public abstract void Play(bool IsNotPaused);
}

// Create another child class inheret from SoundSystem.
class TaxiCar : SoundSystem
{
    public TaxiCar(string model, string make, int year, string registeredOwner) : base(model, make, year, registeredOwner) { }
    
    // Implementation of abstract method from SoundSystem class.
    public override void VolumeLevel(int volLevel) {
        if (volLevel >= 0 && volLevel <= 100) {
            Console.WriteLine($"Volume level: {volLevel}%");
        } else {
            Console.WriteLine("Volume level cannot below 0 and exceed 100!");
        }
    }
    public override void SoundPowerButton(bool IsOn) {
        if (IsOn) {
            Console.WriteLine("Sound system is turned on!");
        } else {
            Console.WriteLine("Sound system is turned off!");
        }
    }

    public override void Play(bool IsNotPause) {
        if (IsNotPause) {
            Console.WriteLine("Music is playing!");
        } else {
            Console.WriteLine("Music is paused!");
        }
        
    }
    public override void Speed(string speed) {  // Polymorphism. Overrides the Speed method from the parent class.
        base.Speed($"{speed}");
    }
}


class Program {
    static void Main(string[] args) {

        Car myCar1 = new Car("Toyota", "Corolla", 2023, "Do Kyung Soo"); // Create an object of a Car class called myCar1.
        Console.WriteLine($"Model: {myCar1.Model}, Make: {myCar1.Make}, Year: {myCar1.Year}");
        myCar1.Drive();
        myCar1.Speed("nomal");  // Polymorphism.
        myCar1.Stop();

        Car myCar2 = new PoliceCar("Toyota", "Innova", 2024, "Park Chan Yeol");
        Console.WriteLine($"Model: {myCar2.Model}, Make: {myCar2.Make}, Year: {myCar2.Year}");
        myCar2.Drive();
        myCar2.Speed("high");   // Polymorphism.
        myCar2.Stop();

        TaxiCar myCar3 = new TaxiCar("Isuzu", "Crosswind ", 2025, "Oh Se Hun");    // Create an object of a TaxiCar class called myCar3.
        Console.WriteLine($"Model: {myCar3.Model}, Make: {myCar3.Make}, Year: {myCar3.Year}");
        myCar3.Drive();
        myCar3.Speed("normal"); // Polymorphism.
        myCar3.SoundPowerButton(true);
        myCar3.Play(true);
        myCar3.VolumeLevel(75);
        myCar3.Stop();
    }
}