// Encapsulation: Data members are private; public methods provide access.
// Abstraction: Hides the complexity of the method's logic.
class Vehicle {
    // Encapsulated fields or attributes reprensenting vehicle properties.
    private string model;
    private string make;
    private int year;

    //Constructor for vehicle properties
    public Vehicle(string model, string make, int year) {
        this.model = model;
        this.make = make;
        this.year = year;
    }

    // Accessor methods for encapsulated attributes.
    public string GetModel() {
        return model;
    }
    public string GetMake() {
        return make;
    }
    public int GetYear() {
        return year;
    }

    // Virtual method representing starting the engine of a vehicle.
    // Abstraction: Hides the implementation details of starting the engine.
    public virtual void StartEngine() {
        Console.Writeline("Starting the vehicle's engine.");
    }
}

// Inheritance: Car class inherits from Vehicle class.
// Polymorphism: Car class overrides the StartEngine method of the base class.
class Car : Vehicle {
    // Constructor for car properties.
    public Car(string model, string make, int year) : base(model, make, year) {
        // Constructor chaining to initialize base class attributes.
    }
    // Method overriding: Overrides the StartEngine method from the base class.
    public override void StartEngine() {
        Console.Writeline("Starting the car's engine.");
    }
    // Method specific to the Car class
    public void Drive() {
        Console.WriteLine("The car is now running.");
    }
    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

class Program {
    static void Main(string[] args) {
        // Polymorphism: Creating a Car object and assigning it to a Vehicle variable.
        Vehicle myVehicle = new Car("Toyota", "Corolla", 2023);

        // Encapsulation: Accessing vehicle properties using public methods.
        Console.WriteLine($"Model: {myVehicle.GetModel()}, Make: {myVehicle.GetMake()}, Year: {myVehicle.GetYear()}");

        // Polymorphism: Invoking the methods on a Vehicle reference;  
        // which dynamically revolves to the overriden method in the car class.
        myVehicle.StartEngine();
        ((Car)myVehicle).Drive();
        ((Car)myVehicle).Stop();
    }
}
