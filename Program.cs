namespace oop
{
    class Car
    {
        public string model;
        private string make;
        private int year;
        private double gas;

        public Car() { }
        public Car(string Model, string Make, int Year, double Gas)
        {
            model = Model;
            make = Make;
            year = Year;
            gas = Gas;

        }

        public string isLatestModel()
        {
            if (year >= 2023)
            {
                return $"{model} is latest";
            }
            return $"{model} is not latest";
        }

        //These methods are a representation of polymorphism

        public void getAllInfo()
        {
            Console.WriteLine(model + " " + make + " " + year);
        }

        public double Gas
        {
            get { return gas; }
            set
            { gas = value; }
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
    class Gas : Car
    {
        public void getGas()
        {
            Console.WriteLine($"Gas of {model} is {Gas}")
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Vios", "Toyota", 1977, 88);
            Car car2 = new Car("Montero", "Mitsubishi", 1978, 78);
            Car car3 = new Car("Model-S", "Tesla", 2023, 67);
            Gas gas1 = new Gas();
            gas1.Make = "NASA"; //in this example, the information of "make" is invalid so the setter will automatically assign the "make" to "NA"
            gas1.model = "Vios";
            gas1.Year = 2024;
            gas1.Gas = 88;

            gas1.getGas();

            Console.WriteLine("These are the valid information of objects:\n\n");
            car1.getAllInfo();
            car2.getAllInfo();
            car3.getAllInfo();


            Console.WriteLine("\n\nThese are example of invalid information of objects which resulted in default information\n\n");
            Car car4 = new Car();
            Car car5 = new Car();
            car4.Make = "NASA"; //in this example, the information of "make" is invalid so the setter will automatically assign the "make" to "NA"
            car4.model = "Vios";
            car4.Year = 2024;
            car4.Gas = 88;

            car5.Make = "Toyota";
            car5.model = "Fortuner";
            car5.Year = -19; // in this example, the information of "year is invalid" so the setter will automatically assign the "year" to "0"
            car5.Gas = 78;
            car4.getAllInfo();
            car5.getAllInfo();

            Console.WriteLine("\n\nThis is an example of inheritance information where this subclass is inherited by the superclass.\n\n");
            Toyota toyota1 = new Toyota();
            toyota1.Make = "Toyota";
            toyota1.model = "Wigo";
            toyota1.Year = 2014;
            toyota1.Gas = 18
            //These 2 functions are inherited from "car" class
            toyota1.getAllInfo();
            toyota1.isLatestCar();

            Console.WriteLine("\n\n This example used the inherited class attributes from car.\n\n");
            Console.WriteLine(toyota1.isToyota());

            Console.ReadLine();
        }
    }
}