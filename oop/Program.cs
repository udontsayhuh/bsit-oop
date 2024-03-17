public abstract class Car {  // Base class
    //test
    //git
    //Attributes
    
    /* _model demonstrates encapsulation because it is declared 
     as private, and is inaccessible from outside the class. 
    The Model property allows controlled access to the _model field's 
    value through 'get'. The 'set' is marked as private, and must be
    modified through the Model property.*/

    private string _model;
    private string _make;
    private int _year;

    public string Model
    {
        // get for accessing the field
        get
        {
            return _model;
        }
        private set // set for modifying the value
        {
            _model = value;
        }
    }

    public string Make
    {
        // get for accessing the field
        get
        {
            return _make;
        }
        private set // set for modifying the value
        {
            _make = value;
        }
    }

    public int Year
    {
        // get for accessing the field
        get
        {
            return _year;
        }
        private set // set for modifying the value
        {
            _year = value;
        }
    }



    //Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    // Abstraction; derived classes implement their own methods. 
    public abstract void Start();

    // Methods
    public void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }

    
}

// Derived class ; SUV inherits the properties and methods of the class Car.

public class SUV : Car
{
    public string Size
    {
        get;
        set;
    }


    // SUV Constructor
    public SUV(string model, string make, int year, string size) : base(model, make, year) // constructor call to the constructor of base class
    {
        Size = size;
    }

    public override void Start() // polymorphism allows the method to be called on objects of different classes on the same interface
    {
        Console.WriteLine("The SUV is starting...");

    }
}


class Program {
    static void Main(string[] args) {
        Car myCar = new SUV("Santa Fe", "Hyundai", 2023, "Mid-size"); // creating new instance of SUV class of type Car
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}, Size: {(myCar as SUV).Size}");
        myCar.Start(); // SUV's own implementation of hte Start() method
        myCar.Drive();
        myCar.Stop();

    }
}
