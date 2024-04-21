using System;
using System.Diagnostics;

namespace Coding_Challenges
{
    internal class SortCars
    {
        public SortCars() {

            Console.WriteLine("\nArray List Sort");
            
            List<String> carList = new List<String>();

            carList = ["Car_4", "Car_1", "Car_5", "Car_3", "Car_2"];
            
            Console.WriteLine("\nOriginal Car List: ");
            PrintValues(carList);

            carList.Sort();

            Console.WriteLine("\nSorted Car List:");
            PrintValues(carList);
        }   

        public void PrintValues(List<String> list)
        {
            foreach (String car in list)
                Console.WriteLine(car);
        }
    }
}
