abstract class Car // Super class
{

    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;
    private string ownerName;       // Encapsulated
    private string ownerContact;    // Encapsulated

    //Properties for Encapsulation 
    public string OwnerName
    {
        get { return ownerName;}
        set { ownerName = value; }
    }

    public string OwnerContact
    {
        get { return ownerContact; }
        set { ownerContact = value; }
    }
    

    //Constructor
    public Car(string model, string make, int year, string ownerName, string ownerContact)
    {   

        Model = model;
        Make = make;
        Year = year;
        OwnerName = ownerName;
        OwnerContact = ownerContact;
        this.ownerName = ownerName;
        this.ownerContact = ownerContact;

    }


    //Methods
    public void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }

    public void sayMotto()
    {

        Console.WriteLine("Override this please!");
    }

    public abstract void makeSound();
}


//Child classes
//
class Ambulance : Car //Inheritance
{

    public int numOfPatient;

    public Ambulance(string Model, string Make, int Year, string ownerName, string ownerContact, int numOfPatient) : base(Model, Make, Year, ownerName, ownerContact)
    {
        this.numOfPatient = numOfPatient;
    }

    public void sayMotto()
    {

        Console.WriteLine("Every Second Counts, Every Life Matters");
    }

    public override void makeSound()
    {
        Console.WriteLine("WEE-OOH WEE-OOH");
    }
}

class SportsCar : Car //Inheritance
{
    public int number;

    public SportsCar(string Model, string Make, int Year, string ownerName, string ownerContact, int number) : base(Model, Make, Year, ownerName, ownerContact)
    {
        this.number = number;
    }

    public void sayMotto()
    {

        Console.WriteLine("Unleash the Thrill!");
    }

    public override void makeSound()
    {
        Console.WriteLine("VROOM");
    }
}

class Program
{
    static void Main(string[] args)
    {


        // INHERITANCE
        // Make an instance for Ambulance
        Ambulance myAmbulance = new Ambulance("Ford", "Transit Ambulance", 2022, "Jolius", "09234254541", 5);
        // Display
        Console.WriteLine("Model: " + myAmbulance.Model);
        Console.WriteLine("Make: " + myAmbulance.Make);
        Console.WriteLine("Year: " + myAmbulance.Year);
        Console.WriteLine("Owner Name: " + myAmbulance.OwnerName);
        Console.WriteLine("Owner Contact: " + myAmbulance.OwnerContact);
        Console.WriteLine("Number of Patients: " + myAmbulance.numOfPatient);

        Console.WriteLine("========================================");

        // Make an instance for Sports Car
        SportsCar mySportsCar = new SportsCar("Porsche", "911", 2021, "Baldomar", "0988763994321", 23);
        // Display
        Console.WriteLine("Model: " + mySportsCar.Model);
        Console.WriteLine("Make: " + mySportsCar.Make);
        Console.WriteLine("Year: " + mySportsCar.Year);
        Console.WriteLine("Owner Name: " + mySportsCar.OwnerName);
        Console.WriteLine("Owner Contact: " + mySportsCar.OwnerContact);
        Console.WriteLine("Number of Patients: " + mySportsCar.number);

        Console.WriteLine("========================================");

        // POLYMORPHISM
        // Display motto for each car
        Console.WriteLine("Car: " + myAmbulance.Make);
        myAmbulance.Drive();
        myAmbulance.sayMotto();
        myAmbulance.Stop();

        Console.WriteLine();

        Console.WriteLine("Car: " + mySportsCar.Make);
        mySportsCar.Drive();
        mySportsCar.sayMotto();
        mySportsCar.Stop();


        // ENCAPSULATION
        // Set value for ownerName and ownerContact
        mySportsCar.OwnerName = "Rhian";
        mySportsCar.OwnerContact = "09278862549";

        Console.WriteLine("========================================");

        // Get value for ownerName and ownerContact and display
        Console.WriteLine("Owner name: " + mySportsCar.OwnerName);
        Console.WriteLine("Owner contact: " + mySportsCar.OwnerContact);

        Console.WriteLine("========================================");

        // ABSTRACTION
        // Display the abstract methods
        Console.WriteLine(myAmbulance.Make);
        myAmbulance.makeSound();
        Console.WriteLine();
        Console.WriteLine(mySportsCar.Make);
        mySportsCar.makeSound()

    }
}
