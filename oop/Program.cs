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
        Console.WriteLine("The car has stopped.\n");
    }
}



class Car2 {
    //test
    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;

    //Constructor
    public Car2(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public void Drive() {
        Console.WriteLine("The car is now starting.");
    }

    public void Stop() {
        Console.WriteLine("The car has crashed.\n");
    }
}






class Car3 {
    //test
    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;
	
    // abstraction 
	private string engine;
	public string Engine { get { return engine; } }
    
	//Constructor
    public Car3(string model, string make, int year, string engine) {
        Model = model;
        Make = make;
        Year = year;
		
    }

    //Methods
    public void Drive() {
        Console.WriteLine("The car is now on cold start.");
    }

    public void Stop() {
        Console.WriteLine("The car broke.");
    }
}





class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
	
	
		Car2 myCar2 = new Car2("Honda", "Civic", 2023);
        Console.WriteLine($"Model: {myCar2.Model}, Make: {myCar2.Make}, Year: {myCar2.Year}");
        myCar2.Drive();
        myCar2.Stop();
		
		
		Car3 myCar3 = new Car3("chevrolet", "Impala", 1963, "Dual Quad 409 V8");
        Console.WriteLine($"Model: {myCar3.Model}, Make: {myCar3.Make}, Year: {myCar3.Year},Engine: {myCar3.Engine}");
        myCar3.Drive();
        myCar3.Stop();
    }
}

