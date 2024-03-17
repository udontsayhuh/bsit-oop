class Car {

    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;

    //PRIVATE ATTRIBUTE VIN: VEHICLE INFORMATION NUMBER
    private string Vehicle_Info_Num;
     
    //GET-SET ENCAPSULATION
    public string VIN
    {
        get { return Vehicle_Info_Num; }
        set { Vehicle_Info_Num = value; }
    }
     
    //Constructor
    public Car(string model, string make, int year, string V_I_N) 
    {
        Model = model;
        Make = make;
        Year = year;
        Vehicle_Info_Num = V_I_N;
    }

    //Methods
    public void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }
    //POLYMORPHISM
    public virtual void show_information()
    {
        Console,WriteLine($"Model: {Model}, Make: {Make}, Year: {Year}, Vehicle Information Number: {VIN}");
    }
}

//ABSTRACTION
abstract class electric_car : Car //INHERITANCE
{
    //UNIQUE ATTRIBUTE
    public int chargeTime;

    public electric_car(string model, string make, int year, string V_I_N, int ChargeTime) : base(model, make, year, V_I_N)
    {
        ChargeTime = chargeTime;
    }
    
    //POLYMORPHISM
    public override voide show_information()
    {
        base.show_information();
        Console.WriteLine($"Charging Time: {chargeTime}");
    }
    public abstract void Charge_battery();
}

class Vintage_Car : Car // INHERITANCE
{
    //UNIQUE ATTRIBUTE
    public bool HaveTouchscreenDisplay;

    //CONSTRUCTOR
    public Vintage_Car(string model, string make, int year, string V_I_N, bool haveTouchScreenDisplay) : base(model, make, year, V_I_N)
    {
        HaveTouchscreenDisplay = haveTouchscreenDisplay; 
    }

        //METHODS
    public void playMusic()
    {
        Console.WriteLine("The car is now playing music 🎵 🎵 🎵");
    }
    
    //POLYMORPHISM
    public override void show_information()
    {
        base.show_information();
        Console.WriteLine($"Do you have Touch Screen Display?: {HaveTouchscreenDispaly});
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
