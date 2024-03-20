using System;

// Base class
abstract class Car {
    /*
    The attributes below are declared as private to show encapsulation.
    */
    private string model;
    private string make;
    private int year;

    // Constructor
    public Car(string model, string make, int year) {
        this.model = model;
        this.make = make;
        this.year = year;
    }

    /*
    The public properties below are used to access the values of the private or encapsulated
    properties. They are accessed using getters and setters.
    */
    public string Model {
        get { return model; }
        set { model = value; }
    }

    public string Make {
        get { return make; }
        set { make = value; }
    }

    public int Year {
        get { return year; }
        set { year = value; }
    }

    /*
    The methods below are declared as abstract to implement the principle
    of abstraction. These methods are not defined since they are declared
    as abstract. This allows to hide the implementation of these methods
    for each concrete subclass.
    */
    public abstract void Drive();
    public abstract void Stop();
}

/*
    The 'Convertible Car' subclass below is a concrete subclass.
    This subclass implements inheritance and polymorphism.
*/
class ConvertibleCar : Car {
    private bool isRoofOpen;

    /*
    The constructor function below uses the keyword 'base' to implement inheritance.
    This allows the 'ConvertibleCar' subclass to inherit the constructor function
    of the superclass 'Car'. Therefore, this subclass also inherits the properties
    of the 'Car' superclass.
    */
    public ConvertibleCar(string model, string make, int year) : base(model, make, year) {
        isRoofOpen = false; // Initially, the roof is closed
    }

    // Method to open the convertible roof
    public void OpenRoof() {
        if (!isRoofOpen) {
            Console.WriteLine("Convertible roof opening...");
            isRoofOpen = true;
        }
        else {
            Console.WriteLine("Convertible roof is already open.");
        }
    }

    // Method to close the convertible roof
    public void CloseRoof() {
        if (isRoofOpen) {
            Console.WriteLine("Convertible roof closing...");
            isRoofOpen = false;
        }
        else {
            Console.WriteLine("Convertible roof is already closed.");
        }
    }

    /*
    The method below overrides or inherits the Drive() method from the superclass 'Car'.
    This shows the principle of inheritance. Not just that, it also applies the principle
    of polymorphism because the Drive() method had its own way of implementation in this
    subclass. This Drive() method from the superclass can be implemented by different
    subclasses on their own way which implements the principle of polymorphism.
    */
    public override void Drive() {
        if (isRoofOpen) {
            Console.WriteLine("Enjoying the drive with the roof down.");
        }
        else {
            Console.WriteLine("Driving the convertible car.");
        }
    }
    /*
    The Stop() method below is also inherited by the subclass 'ConvertibleCar' from
    the superclass 'Car'. Aside from inheritance and polymorphism, this also 
    displays the principle of abstraction since the Stop() method has its own
    abstraction which was hidden in the superclass 'Car'.
    */
    public override void Stop() {
        Console.WriteLine("The convertible car has stopped running.");
    }
}


class Program {
    static void Main(string[] args) {
        /*Since the 'Car' class is declared as abstract to implement the principle of abstraction,
        it is not possible to create an instance or object of this class. You can only
        create an instance or object of a concrete class like the 'ConvertibleCar' class.
        */
        ConvertibleCar newCar = new ConvertibleCar("Mercedes-Benz", "SL-Class", 1954);
        Console.WriteLine($"Model: {newCar.Model}, Make: {newCar.Make}, Year: {newCar.Year}");
        newCar.Drive();
        newCar.Stop();
    }
}



