
namespace oop
{
    class Car
    {
        private string model;
        private string modelmake;
        private int year;



        //getters and setters
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Modelmake
        {
            get { return modelmake; }
            set { modelmake = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Car() { }
        public Car(string Model, string ModelMake, int Year)
        {
            model = Model;
            modelmake = Modelmake;
            year = Year;
        }
    }
    class Horn : Car
    {
        public void peep()
        {
            if (Model == "Ford Fortuner")
            {
                Console.WriteLine($"Model: {Model}\nModelMake: {Modelmake}\nYear: {Year}\n");
                Console.WriteLine($"The horn on the {Modelmake}) was peep!");
            }
            else if (Model == "Honda civic")
            {
                Console.WriteLine($"Model: {Model}\nModelMake: {Modelmake}\nYear: {Year}\n");
                Console.WriteLine($"The horn on the {Modelmake} was broom!");
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Car Car1 = new Car();
            Car1.Model = "Ford Fortuner";
            Car1.Modelmake = "Coupe";
            Car1.Year = 2024;

            Horn horn1 = new Horn();
            horn1.Model = Car1.Model;
            horn1.Modelmake = Car1.Modelmake;
            horn1.Year = 2024;

            horn1.peep();
            Console.ReadLine();
        }
    }
}