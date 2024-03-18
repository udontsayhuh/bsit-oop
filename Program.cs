class Car {
    //test
    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;

    //Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();

    }
}
