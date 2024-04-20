using System;

namespace oop
{
    class Car
    {
        public string model;
        private string make;
        private int year;
        private string enginemodel;
        private int generation;

        // Default constructor
        public Car() { }

        // Parameterized constructor
        public Car(string aModel, string aMake, int aYear, int aGeneration, string aEnginemodel)
        {
            model = aModel;
            make = aMake;
            year = aYear;
            enginemodel = aEnginemodel;
            generation = aGeneration;
        }

        // Method to check if the car is latest based on its year
        public string isLatestCar()
        {
            if (year >= 2023)
            {
                return $"{model} is latest";
            }
            return $"{model} is not latest";
        }

        // Method to display the engine model of the car
        public void getEnginemodel()
        {
            Console.WriteLine($"The engine model of {Make} is {enginemodel}");
        }

        // Method to display all information of the car
        public void getAllInfo()
        {
            Console.WriteLine(model + " " + make + " " + year);
        }

        // Getter and setter for the Generation property
        public int Generation
        {
            get { return generation; }
            set { generation = value; }
        }

        // Getter and setter for the Enginemodel property
        public string Enginemodel
        {
            get { return enginemodel; }
            set { enginemodel = value; }
        }

        // Getter and setter for the Make property
        public string Make
        {
            get { return make; }
            set
            {
                // Validates and sets the make of the car
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

        // Getter and setter for the Year property
        public int Year
        {
            get { return year; }
            set
            {
                // Validates and sets the year of the car
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

    // Example of inheritance with Toyota subclass inheriting from Car superclass
    class Toyota : Car
    {
        // Method to check if the car is a Toyota
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
            // Creating instances of cars
            Car car1 = new Car("Vios", "Toyota", 1977, 00, "Straight or Inline Engine");
            Car car2 = new Car("Montero", "Mitsubishi", 1978, 91, "Flat Engine");
            Car car3 = new Car("Model-S", "Tesla", 2023, 50, "V-Engine");

            // Displaying valid information of cars
            Console.WriteLine("These are the valid information of objects:\n\n");
            car1.getAllInfo();
            car1.getEnginemodel();
            car2.getAllInfo();
            car2.getEnginemodel();
            car3.getAllInfo();
            car3.getEnginemodel();

            // Displaying invalid information of cars
            Console.WriteLine("\n\nThese are example of invalid information of objects which resulted in default information\n\n");
            Car car4 = new Car();
            Car car5 = new Car();
            car4.Make = "NASA"; // Setting invalid make
            car4.model = "Vios";
            car4.Year = 2024;
            car4.Generation = 00;
            car4.Enginemodel = "Straight or Inline Engine";

            car5.Make = "Toyota";
            car5.model = "Fortuner";
            car5.Year = -19; // Setting invalid year
            car5.Generation = 91;
            car5.Enginemodel = "Flat Engine";

            car4.getAllInfo();
            car5.getAllInfo();

            // Example of inheritance with Toyota subclass
            Console.WriteLine("\n\nThis is an example of inheritance information where this subclass is inherited by the superclass.\n\n");
            Toyota toyota1 = new Toyota();
            toyota1.Make = "Toyota";
            toyota1.model = "Wigo";
            toyota1.Year = 2014;
            toyota1.Generation = 80;
            toyota1.Enginemodel = "Twin-Cylinder Engine";

            toyota1.getAllInfo(); // Displaying information of Toyota
            toyota1.isLatestCar(); // Checking if Toyota is latest car

            // Example using inherited class attributes from Car
            Console.WriteLine("\n\n This example used the inherited class attributes from car.\n\n");
            Console.WriteLine(toyota1.isToyota()); // Checking if Toyota is Toyota

            Console.ReadLine();
        }
    }
}
