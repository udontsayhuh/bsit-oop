using System;

class Program {
    static void Main(string[] args){
         
		string[] cars = {"Toyota", "Ford", "Honda", "Tesla", "Volvo"};
		
		// UNSORTED
		Console.WriteLine("UNSORTED LIST: ");
		for (int i = 0; i < cars.Length; i++) {
            Console.WriteLine(cars[i]);
        }
		  
		// SORTED
		Console.WriteLine("\nSORTED LIST: ");
		Array.Sort(cars);
		for (int i = 0; i < cars.Length; i++) {
            Console.WriteLine(cars[i]);
        }
        
    } // Main
} // Program
