using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Car
    {
        public string model;
        private string make;
        private int year;

        public Car() { }
        public Car(string aModel, string aMake, int aYear)
        {
            model = aModel;
            make = aMake;
            year = aYear;

        }
        public string isLatestCar()
        {
            if (year >= 2023)
            {
                return $"{model} is latest";
            }
            return $"{model} is not latest";
        }

        /* [Polymorphism] These methods are a representation of polymorphism as it performs different things as
         * per the object's class in which it calls.
        */
        public void getAllInfo()
        {
            Console.WriteLine(model + " " + make + " " + year);
        }

        // [ABSTRACTION] This 2 properties are like methods but it is a special method that will define a
        // getter and setter to retrieve and modify a data in a strict manner.
        public string Make
        {
            //This will allow manual retrieval of "make" information
            get { return make; }
            //This will allow modifaction but follow a set of standard or rule
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
        //this function used the inherited attribute of car class to perform a new function that is specifically for TOYOTA child class
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
            Car car1 = new Car("Vios", "Toyota", 1977);
            Car car2 = new Car("Montero", "Mitsubishi", 1978);
            Car car3 = new Car("Model-S", "Tesla", 2023);

            Console.WriteLine("These are the valid information of objects:\n\n");
            car1.getAllInfo();
            car2.getAllInfo();
            car3.getAllInfo();

            // This is an example of the line that will not work
            //
            //          Console.WriteLine(car2.make);
            //
            // because the attribute "make" is only accessible in the class

            Console.WriteLine("\n\nThese are example of invalid information of objects which resulted in default information\n\n");
            Car car4 = new Car();
            Car car5 = new Car();
            car4.Make = "NASA"; //in this example, the information of "make" is invalid so the setter will automatically assign the "make" to "NA"
            car4.model = "Vios";
            car4.Year = 2024;

            car5.Make = "Toyota";
            car5.model = "Fortuner";
            car5.Year = -19; // in this example, the information of "year is invalid" so the setter will automatically assign the "year" to "0"

            car4.getAllInfo();
            car5.getAllInfo();

            Console.WriteLine("\n\nThis is an example of inheritance information where this subclass is inherited by the superclass.\n\n");
            Toyota toyota1 = new Toyota();
            toyota1.Make = "Toyota";
            toyota1.model = "Wigo";
            toyota1.Year = 2014;
            //These 2 functions are inherited from "car" class
            toyota1.getAllInfo();
            toyota1.isLatestCar();

            Console.WriteLine("\n\n This example used the inherited class attributes from car.\n\n");
            Console.WriteLine(toyota1.isToyota());

            Console.ReadLine();
        }
    }



}



