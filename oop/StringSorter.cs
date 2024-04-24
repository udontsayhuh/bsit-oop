using System;
using System.Collections;

/*
    The interface below promotes Open/Closed Principle because any necessary changes for CreateList() method
does not make the method open for modification but rather open for extension by creating another class which 
will inherit the interface below in order to have another specific implementation for the CreateList() method.

    Due to the fact that the class inherits the interface, an object of the interface can be created through
the instance of the class just like the ConsoleListCreation class below. This deploys the Liskov Substitution
principle because the object of the superclass (which is the interface in this program) was able to be replaced
by the object of the subclass (which is the class in this program) without affecting the correctness of the program. 
This is evident in the Main method where I labeled with 'LSP'.

    Lastly, the classes below follow the Single-Responsibility Principle as each of the class has only one
responsibility.
*/

interface IListCreation {
    ArrayList CreateList();
}

// Class Role: Create a list via pre-defined names of cars
class ConsoleListCreation : IListCreation {
    private ArrayList _cars = new ArrayList();
    public ArrayList CreateList() {
        _cars.Add("Volkswagen Golf");    
        _cars.Add("Cadillac Escalade"); 
        _cars.Add("Tesla Model S");
        _cars.Add("Hyundai Sonata");
        _cars.Add("Audi A4");
        
        return _cars;
    }
}

// Class Role: Displays the list of unsorted cars
class UnsortedListDisplay {
    public static void DisplayUnsortedList(ArrayList cars) {
        Console.WriteLine("\nList of Unsorted Cars: ");
        foreach (var car in cars) {
            Console.WriteLine($" - {car}");
        }
    }
}

// Class Role: Sorts the list of strings (which in this program is 'cars')
class ListSorter {
    public static ArrayList SortList(ArrayList cars) {
        cars.Sort();
        return cars;
    }
}

// Class Role: Displays the sorted list of cars
class SortedListDisplay {
    public static void DisplaySortedList(ArrayList cars) {
        Console.WriteLine("\nList of Sorted Cars: ");
        foreach (var car in cars) {
            Console.WriteLine($" - {car}");
        }
    }
}

// Class Role: Performs the sequence of the StringSorter program
class StringSorterProgram {
    public static void Main(string[] args) {
        Console.WriteLine("Welcome to String Sorter!");
        IListCreation list = new ConsoleListCreation();  // Application of LSP

        // Create a list of cars via pre-defined names of cars
        ArrayList unsortedCars = list.CreateList();

        // Display the unsorted list of cars
        UnsortedListDisplay.DisplayUnsortedList(unsortedCars);

        // Sort the list of cars
        ArrayList sortedCars = ListSorter.SortList(unsortedCars);

        // Display the sorted list of cars
        SortedListDisplay.DisplaySortedList(sortedCars);
    }
}
