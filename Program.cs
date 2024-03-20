using System; 

// Abstract class Vehicle
abstract class Vehicle { // Declaring an abstract class called Vehicle
    // Attributes
    public string Model { get; set; } // Declaring a public property for Model attribute
    public string Make { get; set; } // Declaring a public property for Make attribute
    public int Year { get; set; } // Declaring a public property for Year attribute

    // Abstract method
    public abstract void Drive(); // Declaring an abstract method Drive() which will be implemented by subclasses
}

// Car class inherits from Vehicle
class Car : Vehicle { // Declaring a class Car which inherits from the Vehicle class
    // Constructor
    public Car(string model, string make, int year) { // Declaring a constructor for Car class
        Model = model; // Assigning the value of model parameter to the Model property
        Make = make; // Assigning the value of make parameter to the Make property
        Year = year; // Assigning the value of year parameter to the Year property
    }

    // Implementation of abstract method
    public override void Drive() { // Implementing the abstract Drive method from the Vehicle class
        Console.WriteLine("The car is now running."); // Printing a message indicating the car is running
    }

    public void Stop() { // Declaring a method Stop() in the Car class
        Console.WriteLine("The car has stopped."); // Printing a message indicating the car has stopped
    }
}

// ElectricCar class inherits from Car
class ElectricCar : Car { // Declaring a class ElectricCar which inherits from the Car class
    // Constructor
    public ElectricCar(string model, string make, int year) : base(model, make, year) { // Declaring a constructor for ElectricCar class
    }

    // Override method
    public override void Drive() { // Overriding the Drive method from the Car class
        Console.WriteLine("The electric car is now running silently."); // Printing a message
}

class Program {
    static void Main(string[] args) { // Main method
        Car myCar = new Car("Toyota", "Corolla", 2023); // Creating an instance of Car class
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}"); // Printing
        myCar.Drive(); // Calling the Drive method of the Car class
        myCar.Stop(); // Calling the Stop method of the Car class

        ElectricCar myElectricCar = new ElectricCar("Tesla", "Model S", 2024); // Creating an instance of ElectricCar class
        Console.WriteLine($"Model: {myElectricCar.Model}, Make: {myElectricCar.Make}, Year: {myElectricCar.Year}"); 
    }
}
