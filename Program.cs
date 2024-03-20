using System;

abstract class Vehicle {
    private string model;
    private string make;
    private int year;
    private string owner;

    public Vehicle(string model, string make, int year, string owner) {
        this.model = model;
        this.make = make;
        this.year = year;
        this.owner = owner;
    }

    public string GetModel() {
        return model;
    }

    public string GetMake() {
        return make;
    }

    public int GetYear() {
        return year;
    }
    
    public string GetOwner(){
        return owner;
    }

    public abstract void Start();

    public virtual void Drive() {
        Console.WriteLine("\nThe vehicle is now running.");
    }

    public void Stop() {
        Console.WriteLine("The vehicle has stopped.");
    }
}

class Car : Vehicle {
    public Car(string model, string make, int year, string owner) : base(model, make, year, owner) {
    }

    public override void Start() {
        Console.WriteLine("\nThe car engine is starting.");
    }

    public override void Drive() {
        Console.WriteLine("The car is now running.");
    }
}
class ExpensiveCar : Car {
    public ExpensiveCar(string model, string make, int year, string owner) : base(model, make, year, owner){
    }
    public override void Drive() {
        Console.WriteLine("\nThe Expensive Car is starting.");
    }
    public override void Start(){
        Console.WriteLine("Turning on the headlights.");
    }
}


class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023, "Tony Stark");
        Console.WriteLine($"Model: {myCar.GetModel()}, Make: {myCar.GetMake()}, Year: {myCar.GetYear()}, Owner:{myCar.GetOwner()} ");
        myCar.Start();
        myCar.Drive();
        myCar.Stop();
        
        ExpensiveCar myExpensiveCar = new ExpensiveCar("Ferrari", "Portofino M", 2020, "Eren Yeager");
        Console.WriteLine($"\n\nModel:{myExpensiveCar.GetModel()}, Make: {myExpensiveCar.GetMake()}, Year: {myExpensiveCar.GetYear()}, Owner: {myExpensiveCar.GetOwner()}");
        myExpensiveCar.Drive();
        myExpensiveCar.Start();
    }
}
