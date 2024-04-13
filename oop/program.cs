using System;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Carbase a = new Car("Toyota", "Corolla", 2023);
            Console.WriteLine($"Model: {a.Model}, Make: {a.Make}, Year: {a.Year}");
            a.Drive();
            a.Stop();
            a.Break();
            a.Accelerate();

            Ownercar b = new Ownercar("Althea", "RJ1234", 987654321, "Honda", "Adventure", 2024);
            Console.WriteLine($"Model: {b.Model}, Make: {b.Make}, Year: {b.Year}");
            b.Drive();
            b.Stop();
            b.Break();
            b.Accelerate();
            b.Info();

            BuyCar d = new BuyCar("Tesla", "Adventure", 2023, "Amor", 31, 1993);
            Console.WriteLine($"Model: {d.Model}, Make: {d.Make}, Year: {d.Year}");
            d.Drive();
            d.Stop();
            d.Break();
            d.Accelerate();
            d.Buyer();
        }
    }

    public abstract class Carbase
    {    //Encapsulation
        public string Model { get; }
        public string Make { get; }
        public int Year { get; }

        public Carbase(string model, string make, int year)
        {
            Model = model;
            Make = make;
            Year = year;
        }
        //abstraction
        public abstract void Drive();
        public abstract void Stop();
        public abstract void Break();
        public abstract void Accelerate();
    }

    public class Car : Carbase
    {    //inheritance 
        public Car(string model, string make, int year) : base(model, make, year) { }
        public override void Drive()
        {
            Console.WriteLine("The car is now running.");
        }

        public override void Stop()
        {
            Console.WriteLine("The car has stopped.");
        }
        public override void Break()
        {
            Console.WriteLine("Break because of the stoplight.");
        }

        public override void Accelerate()
        {
            Console.WriteLine("The speed accelerate up to 200kms");
        }
    }

    public class Ownercar : Carbase
    {   //Encapsulation
        private string owner;
        private string platenum;
        private int contactnum;

        public Ownercar(string owner, string platenum, int contactnum, string model, string make, int year) : base(model, make, year)
        {
            this.owner = owner;
            this.platenum = platenum;
            this.contactnum = contactnum;
        }

        public void Info()
        {
            Console.WriteLine($"Owner: {owner}, Plate Number: {platenum}, Contact Number: {contactnum}");
        }
        //polymophism 
        //Overrides base class methods with specific implementations.
        public override void Drive()
        {
            Console.WriteLine("Owner's car is now running.");
        }
        public override void Stop()
        {
            Console.WriteLine("Owner's car has stopped.");
        }
        public override void Break()
        {
            Console.WriteLine("Owner's car breaks for a stop sign.");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Owner's car accelerates smoothly.");
        }
    }
    public class BuyCar : Carbase
    {
        //properties have only a getter method and no setter method. Therefore, they can be read from outside the class but cannot be modified.
        public string NameOfTheBuyer { get; }
        public int AgeOfTheBuyer { get; }
        public int BdayOfTheBuyer { get; }

        public BuyCar(string model, string make, int year, string nameOfTheBuyer, int ageOfTheBuyer, int bdayOfTheBuyer)
            : base(model, make, year)
        {
            NameOfTheBuyer = nameOfTheBuyer;
            AgeOfTheBuyer = ageOfTheBuyer;
            BdayOfTheBuyer = bdayOfTheBuyer;
        }
        public void Buyer()
        {
            Console.WriteLine($"Name of the Buyer: {NameOfTheBuyer}, Age of the Buyer: {AgeOfTheBuyer}, Birth Year: {BdayOfTheBuyer}");
        }
        public override void Drive()
        {
            Console.WriteLine("Buyer's car is now running.");
        }
        public override void Stop()
        {
            Console.WriteLine("Buyer's car has stopped.");
        }
        public override void Break()
        {
            Console.WriteLine("Buyer's car breaks for a red light.");
        }
        public override void Accelerate()
        {
            Console.WriteLine("Buyer's car accelerates aggressively.");
        }
    }
}
