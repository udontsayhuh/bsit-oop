namespace oop
{
    class Car
    {
        public string model;
        private string make;
        private int year;
        private string enginemodel;
        private int generation;

        public Car() { }
        public Car(string aModel, string aMake, int aYear, int aGeneration, string aEnginemodel)
        {
            model = aModel;
            make = aMake;
            year = aYear;
            enginemodel = aEnginemodel;
            generation = aGeneration;

        }

        public string isLatestCar()
        {
            if (year >= 2023)
            {
                return $"{model} is latest";
            }
            return $"{model} is not latest";
        }


        public void getEnginemodel()
        {
            Console.WriteLine($"The engine model of {Make} is {enginemodel}")
            }

        //These methods are a representation of polymorphism

        public void getAllInfo()
        {
            Console.WriteLine(model + " " + make + " " + year);
        }

        //This 2 properties are like methods but it is a special method that will define a
        // getter and setter to retrieve and modify a data in a strict manner.

        public int Generation
        {
            get { return generation; }
            set { Generation = value; }
        }

        public string Enginemodel
        {
            get { return enginemodel; }
            set { enginemodel = value; }
        }

        public string Make
        {
            get { return make; }
            set
            {
                if (value == "Toyota" || value == "Ford" || value == "Honda" || value == "Mitsubishi" || value == "Tesla" || value == "NA")
                {
                    make = value;
                }
                else
                {
                    make = "NA";
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 0)
                {
                    year = value;
                }
                else
                {
                    year = 0;
                }
            }
        }
    }

    //This is an example of inheritance 
    class Toyota : Car
    {
        //this function used the inherited attribute of car class
        public string isToyota()
        {
            if (Make == "Toyota")
            {
                return $"{model} is Toyota";
            }
            return $"{model} is not Toyota";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Vios", "Toyota", 1977, 00, "Straight or Inline Engine");
            Car car2 = new Car("Montero", "Mitsubishi", 1978, 91, "Flat Engine");
            Car car3 = new Car("Model-S", "Tesla", 2023, 50, "V-Engine");

            Console.WriteLine("These are the valid information of objects:\n\n");
            car1.getAllInfo();
            car1.getEnginemodel();
            car2.getAllInfo();
            car2.getEnginemodel();
            car3.getAllInfo();
            car3.getEnginemodel();

            Console.WriteLine("\n\nThese are example of invalid information of objects which resulted in default information\n\n");
            Car car4 = new Car();
            Car car5 = new Car();
            car4.Make = "NASA"; //in this example, the information of "make" is invalid so the setter will automatically assign the "make" to "NA"
            car4.model = "Vios";
            car4.Year = 2024;
            car4.Generation = 00;
            car4.Enginemodel = "Straight or Inline Engine";

            car5.Make = "Toyota";
            car5.model = "Fortuner";
            car5.Year = -19; // in this example, the information of "year is invalid" so the setter will automatically assign the "year" to "0"
            car5.Generation = 91;
            car5.Enginemodel = "Flat Engine";

            car4.getAllInfo();
            car5.getAllInfo();

            Console.WriteLine("\n\nThis is an example of inheritance information where this subclass is inherited by the superclass.\n\n");
            Toyota toyota1 = new Toyota();
            toyota1.Make = "Toyota";
            toyota1.model = "Wigo";
            toyota1.Year = 2014;
            toyota1.Generation = 80;
            toyota1.Enginemodel = "Twin-Cylinder Engine";
            //These 2 functions are inherited from "car" class
            toyota1.getAllInfo();
            toyota1.isLatestCar();

            Console.WriteLine("\n\n This example used the inherited class attributes from car.\n\n");
            Console.WriteLine(toyota1.isToyota());

            Console.ReadLine();
        }
    }
}