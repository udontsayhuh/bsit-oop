//Abstract Class, a Vehicle object can no longer be created
//Must use a child class to create an object
abstract class Vehicle
{

    //Encapsulation
    //Make attributes only visible by the class or the class' subclasses
    protected string model;
    protected string make;
    protected int year;
 
    //Abstract method, every child class should have their own implementation of the toString method
    public abstract void toString();

    //Create methods to override in child classes
    //If an overriden method is not defined, these methods will be used
    public virtual void move()
    {
        Console.WriteLine("The Vehicle is now moving.\n");
    }

    public virtual void stop()
    {
        Console.WriteLine("The Vehicle has stopped.\n");
    }
}

//Inheritance
//Inherit the attributes and methods form Vehicle class
class Car : Vehicle {

    //git
    //Attributes
    private string wheel_type;

    //Constructor
    public Car(string model, string make, int year, string wheel_type) {
        this.model = model;
        this.make = make;
        this.year = year;
        this.wheel_type = wheel_type;
    }

    //Methods
    public override void toString() {
     Console.WriteLine($"Model: {model}\nMake: {make}\nYear: {year}\nType of Wheel: {wheel_type}\n");
    }

    //Polymorphism
    //Override inherited methods
    public void move() {
        Console.WriteLine($"The car, {model} {make} is now moving.\n");
    }

    public void stop() {
        Console.WriteLine($"The car, {model} {make} has stopped.\n");
    }
}

//Inheritance
//Inherit the attributes and methods form Vehicle class
class Boat : Vehicle
{

    //Attributes
    private string propulsion_type;

    //Constructor
    public Boat(string model, string make, int year, string propulsion_type)
    {
        this.model = model;
        this.make = make;
        this.year = year;
        this.propulsion_type = propulsion_type;
    }

    //Methods
    public override void toString()
    {
        Console.WriteLine($"Model: {model}\nMake: {make}\nYear: {year}\nType of Propulsion: {propulsion_type}\n");
    }

    //Polymorphism
    //Override inherited methods
    public override void move()
    {
        Console.WriteLine($"The Boat, {model} {make} is now moving.\n");
    }

    public override void stop()
    {
        Console.WriteLine($"The Boat, {model} {make} has stopped.\n");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023, "Alloy");
        myCar.toString();
        myCar.move();
        myCar.stop();
    
        Boat myBoat = new Boat("Montauk 170", "Boston Whaler", 2022, "Outboard Motor");
        myBoat.toString();
        myBoat.move();
        myBoat.stop();

    }
}
