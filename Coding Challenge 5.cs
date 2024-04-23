using System;

//A program that contains 5 cars and sort them
class Cars
{
    public static void Main(string[] args)
    {   
        //To initialized an array list that contains 5 cars
        string[] CarList = { "Honda", "Toyota", "Ferrari", "Porche", "Chevrolet" };
        
        //To dispay the original list
        Console.WriteLine("ORIGINAL LIST: ");

        //for loop to iterate each elements of an array and then print it in original list
        for (int i = 0; i < CarList.Length; i++)
        {
            Console.WriteLine(CarList[i]);
        }

        //To display the sorted list of cars 
        Console.WriteLine("\nTHE LIST OF CARS IN SORTED ORDER: ");
        Array.Sort(CarList); //method to sort the array list 

        //for loop to iterate each elements of an array and then print it in sorted order
        for (int i = 0; i < CarList.Length; i++)
        {
            Console.WriteLine(CarList[i]);
        }

    }
}
