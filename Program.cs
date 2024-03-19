namespace oop
{
    class Car
    {
        public string model;
        private string make;
        private int year;
        private string name;
        private int age;

        public Car() { }
        public Car(string aModel, string aMake, int aYear, int aAge, string aName)
        {
            model = aModel;
            make = aMake;
            year = aYear;
            name = aName;
            age = aAge;

        }

        public string isLatestCar()
        {
            if (year >= 2023)
            {
                return $"{model} is latest";
            }
            return $"{model} is not latest";
        }


        public void getName()
        {
            Console.WriteLine($"The owner of {Make} is {Name}")
            }

        //These methods are a representation of polymorphism

        public void getAllInfo()
        {
            Console.WriteLine(model + " " + make + " " + year);
        }

        //This 2 properties are like methods but it is a special method that will define a
        // getter and setter to retrieve and modify a data in a strict manner.

        public int Age
        {
            get { return age; }
            set { Age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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
            Car car1 = new Car("Vios", "Toyota", 1977, 26, "andrea");
            Car car2 = new Car("Montero", "Mitsubishi", 1978, 89, "ralph");
            Car car3 = new Car("Model-S", "Tesla", 2023, 67, "lars");

            Console.WriteLine("These are the valid information of objects:\n\n");
            car1.getAllInfo();
            car1.getName();
            car2.getAllInfo();
            car2.getName();
            car3.getAllInfo();
            car3.getName();

            Console.WriteLine("\n\nThese are example of invalid information of objects which resulted in default information\n\n");
            Car car4 = new Car();
            Car car5 = new Car();
            car4.Make = "NASA"; //in this example, the information of "make" is invalid so the setter will automatically assign the "make" to "NA"
            car4.model = "Vios";
            car4.Year = 2024;
            car4.Age = 26;
            car4.Name = "andrea";

            car5.Make = "Toyota";
            car5.model = "Fortuner";
            car5.Year = -19; // in this example, the information of "year is invalid" so the setter will automatically assign the "year" to "0"
            car5.Age = 89;
            car5.Name = "ralph";

            car4.getAllInfo();
            car5.getAllInfo();

            Console.WriteLine("\n\nThis is an example of inheritance information where this subclass is inherited by the superclass.\n\n");
            Toyota toyota1 = new Toyota();
            toyota1.Make = "Toyota";
            toyota1.model = "Wigo";
            toyota1.Year = 2014;
            toyota1.Age = 18;
            toyota1.Name = "ashley";
            //These 2 functions are inherited from "car" class
            toyota1.getAllInfo();
            toyota1.isLatestCar();

            Console.WriteLine("\n\n This example used the inherited class attributes from car.\n\n");
            Console.WriteLine(toyota1.isToyota());

            Console.ReadLine();
        }
    }
}