using System.Collections;

class Cars
{
    static void Main(string[] args)
    {
        ArrayList cars = new ArrayList();

        // Adding cars to the list
        cars.Add("Toyota Vios");
        cars.Add("Honda City");
        cars.Add("Mitsubishi Mirage");
        cars.Add("Nissan Almera");
        cars.Add("Kia Rio");

        // Sorting the list
        cars.Sort();

        // Displaying the sorted list
        Console.WriteLine("Sorted list of cars:");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
