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

    public virtual void show_information()
    {
        Console,WriteLine($"Model: {Model}, Make: {Make}, Year: {Year}, Vehicle Information Number: {VIN}");
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
