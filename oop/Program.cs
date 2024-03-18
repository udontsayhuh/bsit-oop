using System;

namespace OOPfirst
{

    // Parent Class
    class Car
    {
        // Encapsulation for private fields
        private string brand_name;
        private string brand_model;
        public int year;

        // The getter and setter is part of abstraction.
        public string Brand_name
        {
            get { return brand_name; }
            set { brand_name = value; }
        }
        public string Brand_model
        {
            get { return brand_model; }
            set { brand_model = value; }
        }
        public Car() { }
        public Car(string Brand_name, string Brand_model, int Year)
        {
            brand_name = Brand_name;
            brand_model = Brand_model;
            year = Year;
        }

    }
    // Inheritance
    class Toyota : Car
    {
        // Polymorphism
        public void acolors()
        {
            if (Brand_model == "Vios")
            {
                Console.WriteLine($"Brand Name: {Brand_name}\nModel: {Brand_model}\nYear: {year}\n");
                Console.WriteLine($"The colors available for {Brand_model} are Red, Gray, Black");
            }
            else if (Brand_model == "Wigo")
            {
                Console.WriteLine($"Brand Name: {Brand_name}\nModel: {Brand_model}\nYear: {year}\n");
                Console.WriteLine($"The colors available for {Brand_model} are White, Silver, Blue");
            }
            else if (Brand_model == "Fortuner")
            {
                Console.WriteLine($"Brand Name: {Brand_name}\nModel: {Brand_model}\nYear: {year}\n");
                Console.WriteLine($"The colors available for {Brand_model} are Maroon and Silver");
            }
            else if (Brand_model == "Innova")
            {
                Console.WriteLine($"Brand Name: {Brand_name}\nModel: {Brand_model}\nYear: {year}\n");
                Console.WriteLine($"The colors available for {Brand_model} are White, Black, Green");
            }
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Toyota Toyota1 = new Toyota();
            Toyota1.Brand_model = "Fortuner";
            Toyota1.Brand_name = "Toyota";
            Toyota1.year = 1999;

            Toyota1.acolors();

            Console.ReadLine();
        }
    }
}
