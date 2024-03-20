using System;

public class Vehicle {

    //Attributes
    public string Make;
    private string Model;
    private int Year;

    public string Model
    {
        get { return Model; }
        set { Model = value; }  
    }

    public int Year
    {
        get { return Year; }
        set { Year = value; }  
    }

    //Methods
    public virtual void Drive();

    public virtual void Stop();
}

public class Car : Vehicle
{
    private string maintenanceSchedule;
    private string transmissionType;
    private bool hasNavigationSystem;

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

    public override void Drive()
    {
        Console.WriteLine("The car is driving");
    }
}

class Program {
    static void Main(string[] args) {
        Car ericeCar = new Car("Porsche", "911 Coupe", 2024);

        myCar.MaintenanceSchedule = "Every 10000 miles";
        myCar.TransmissionType = "Manual";
        myCar.HasNavigationSystem = true;
        
        Console.WriteLine($"Model: {myCar.Model}, Year: {myCar.Year}");
        Console.WriteLine($"Maintenance Schedule: {myCar.MaintenanceSchedule}");
        Console.WriteLine($"Transmission Type: {myCar.TransmissionType}");
        Console.WriteLine($"Has Navigation System: {myCar.HasNavigationSystem}");
        myCar.Drive();
        myCar.Stop();
    }
}
