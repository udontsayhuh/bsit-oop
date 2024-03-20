using System;

public class Vehicle
{
    // Attributes
    public string make; // Encapsulation: The 'make' attribute is public and directly accessible.

    private string model; // Encapsulation: The 'model' attribute is private and accessed through a property.

    private int year; // Encapsulation: The 'year' attribute is private and accessed through a property.

    public string Model
    {
        get { return model; } 
        set { model = value; } 
    }

    public int Year
    {
        get { return year; } 
        set { year = value; } 
    }

    // Methods
    public virtual void Drive()  // Abstraction and Polymorphism: Providing an abstract behavior for driving that can be overridden.
    {
        Console.WriteLine("The vehicle is driving");
    }

    public virtual void Stop()  // Abstraction and Polymorphism: Providing an abstract behavior for stopping that can be overridden.
    {
        Console.WriteLine("The vehicle is stopping");
    }
}

public class Car : Vehicle  // Inheritance: The Car class inherits from the Vehicle class.
{
    private string maintenanceSchedule; // Encapsulation: The 'maintenanceSchedule' attribute is private and accessed through a property.

    private string transmissionType; // Encapsulation: The 'transmissionType' attribute is private and accessed through a property.

    private bool hasNavigationSystem; // Encapsulation: The 'hasNavigationSystem' attribute is private and accessed through a property.

    public string MaintenanceSchedule
    {
        get { return maintenanceSchedule; } 
        set { maintenanceSchedule = value; } 
    }

    public string TransmissionType
    {
        get { return transmissionType; } 
        set { transmissionType = value; } 
    }

    public bool HasNavigationSystem
    {
        get { return hasNavigationSystem; } 
        set { hasNavigationSystem = value; } 
    }

    public override void Drive() // Polymorphism: Overriding the Drive method from the base class.
    {
        Console.WriteLine("The car is driving");
    }

    public override void Stop() // Polymorphism: Overriding the Stop method from the base class.
    {
        Console.WriteLine("The car is stopping");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a Vehicle object (Miata)
        Vehicle myMiata = new()
        {
            make = "Mazda",
            Model = "Miata",
            Year = 2022
        };

        Console.WriteLine($"Make: {myMiata.make}, Model: {myMiata.Model}, Year: {myMiata.Year}");
        myMiata.Drive();
        myMiata.Stop();

        Console.WriteLine();

        // Creating a Car object (911 Coupe)
        Car ericeCar = new()
        {
            make = "Porsche",
            Model = "911 Coupe",
            Year = 2024,

            MaintenanceSchedule = "Every 10000 miles",
            TransmissionType = "Manual",
            HasNavigationSystem = true
        };
        Console.WriteLine($"Make: {ericeCar.make},    Year: {ericeCar.Year}");
        Console.WriteLine($"Model: {ericeCar.Model}");
        Console.WriteLine($"Maintenance Schedule: {ericeCar.MaintenanceSchedule}");
        Console.WriteLine($"Transmission Type: {ericeCar.TransmissionType}");
        Console.WriteLine($"Has Navigation System: {ericeCar.HasNavigationSystem}");
        ericeCar.Drive();
        ericeCar.Stop();
    }
}
