using System; 

class Car //base class/parent for INHERITANCE
{
    public string alphaplate = "AKI";
    //methods

    //method #1
    public void Accelerate()
    {
        Console.WriteLine("Car Accelerating");
    }

    //method #2
    //ENCAPSULATION
    //set to private for encapsulation
    private void Brake()
    {
        Console.WriteLine("Car stopped");
    } 

    public void JapaneseCar()
    {
        Console.WriteLine("This brand is a Japanese Automaker ");
    }
}

class CarPlate : Car  //derived class/child for INHERITANCE
{
    public int numeric = 32204;
}

class Toyota : Car //INHERITANCE and POLYMORPHISM
{
    public void JapaneseCar()
    {
        Console.WriteLine("Japanese Car");
    }
}
class Nissan : Car //INHERITANCE and POLYMORPHISM
{
    public void JapaneseCar()
    {
        Console.WriteLine("Japanese Car");
    }
}

//abstract class
//cannot make an object since it is abstract
abstract class LockedCar
{
    public abstract void unlockcar();
    public void unlocked()
    {
        Console.WriteLine("Car unlock Successful");
    }
}

//accessing the abstract class by inheritance and polymorphism
class Key : LockedCar
{
    public override void unlockcar()
    {
        Console.WriteLine("Unlocking Car");
    }
}
class Program
{
    static void Main(string[] args)
    {
        CarPlate car = new CarPlate();

        //checking public ENCAPSULATION
        //calling method accelerate
        Console.WriteLine("Checking ENCAPSULATION. \nNote: Public Method is shown and Private is not.");
        car.Accelerate();

        //checking private ENCAPSULATION
        //wil result to error cus Brake is set to private
        //car.Brake();

        //INHERITANCE
        Console.WriteLine("\nINHERITANCE. \nNote: Combining 'AKI' and 32204 from different classes.");
        Console.WriteLine($"Full plate number: {car.alphaplate}{car.numeric}");

        //POLYMORPHISM
        Console.WriteLine("\nPOLYMORPHISM. \nNote: Prints the method in the base class if the derived classes has the same method implemented.");
        Car myCar = new Car();
        Car myNissan = new Nissan();
        Car myToyota = new Toyota();

        myNissan.JapaneseCar(); 
        myToyota.JapaneseCar();


        //ABSTRACTION
        Console.WriteLine("\nABSTRACTION. \nNote: Accessing the abstract class and methods thru Inheritance and Polymorphism."); 
        Key myKey = new Key();  
        myKey.unlockcar();
        myKey.unlocked();
    }
}
