using System;
using System.ComponentModel.DataAnnotations;

class List
{
    static void Main(string[] args)

    {
        List<string> carBrand = new List<string>();

        carBrand.Add("BMW");
        carBrand.Add("Audi");
        carBrand.Add("Volkswagen");
        carBrand.Add("Chevrolet");
        carBrand.Add("Porche");

        carBrand.Sort();

        Console.Write("Sorted list of Car Brands:\n");
        foreach (string item in carBrand)
        {
            Console.WriteLine(item);
        }
    }
}