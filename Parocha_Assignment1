abstract class Vehicle { // implementing abstraction

    private string Model; // implementing encapsulation
    private string Make;
    private int Year;
    private string Color;

    public void getInfo(string model, string make, int year) { // implementing polymorphism
        this.Model = model;
        this.Make = make;
        this.Year = year;
    }

    public void showInfo() { // implementing polymorphism
        Console.WriteLine($"Model: {Model}, Make: {Make}, Year: {Year}");

    }
    public void getColor(string color) { // implementing polymorphism
        this.Color = color;
    }
    
    public void showColor(){ // implementing polymorphism
        Console.WriteLine("Color: " + Color);
    }
     public void Drive() { // implementing polymorphism
        Console.WriteLine("The car is now running.");
    }

    public void Stop() { // implementing polymorphism
        Console.WriteLine("The car has stopped.");
    }
    public abstract void engine(); // declaring an abstract method 

}

class Car : Vehicle { // implementing inheritance using colon(:)
     public override void engine() { // overriding an abstract method
        Console.WriteLine("brrrr");
     }
}

class Motor : Vehicle {
    public override void engine() { // overriding an abstract method
        Console.WriteLine("broom broom");
     }
}

class Program {
    public static void Main(string[] args) {
        Car myCar = new Car(); // create new object
        Motor myMotor = new Motor(); // create new object

        myCar.getInfo("Toyota", "Corolla", 2023);
        myCar.getColor("Black");
        myMotor.getInfo("Honda", "Goldwing", 2024);
        myMotor.getColor("Pink");

        myCar.showInfo();
        myCar.showColor();
        myCar.engine();
        myCar.Drive();
        myCar.Stop();

        Console.WriteLine("\n------------------------------------------\n");

        myMotor.showInfo();
        myMotor.showColor();
        myMotor.engine();
        myMotor.Drive();
        myMotor.Stop();
        
        Console.ReadKey();
    }
}

/*
Submitted By: Miyuki Mharie C. Parocha
Year/Section: BSIT 2-2
*/
