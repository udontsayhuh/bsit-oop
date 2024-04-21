class Program {
      static void Main(string[] args) {
            
			// SubMenu
			Console.WriteLine("CALCULATOR!\n");
			SubMenu();
          
      } // Main
		
	  static void SubMenu() {
            
			// INPUT 
			
			Console.WriteLine("Choose an operator: ");
			Console.WriteLine("1) Addition\n2) Subtraction\n3) Multiplication\n4) Division");
			

			Console.Write("\nChoose 1/2/3/4: ");
			char choice = char.Parse(Console.ReadLine());
			
			switch (choice) {
                 
				case '1':
				Add();
				break;
				
				case '2':
				Sub();
				break;
				
				case '3':
				Prod();
				break;
				
				case '4':
				Quo();
				break;
				
				default:
				Console.WriteLine("Invalid Input! ");
				Console.Clear();
				SubMenu();
				break;
                
            } // Switch
				
			Cont();

          
      } // SubMenu
		
		
	  static void Add() {
          
			float num_1 = 0;
			float num_2 = 0;
			
			Console.Write("Enter a number: ");
			num_1 = float.Parse(Console.ReadLine());
			Console.Write("Enter a number: ");
			num_2 = float.Parse(Console.ReadLine());
			
			Console.WriteLine("The sum is: "+ (num_1 + num_2));
			
      } // Add
		
		
	  static void Sub() {
          
			float num_1 = 0;
			float num_2 = 0;
			
			Console.Write("Enter a number: ");
			num_1 = float.Parse(Console.ReadLine());
			Console.Write("Enter a number: ");
			num_2 = float.Parse(Console.ReadLine());
			
			Console.WriteLine("The difference is: "+ (num_1 - num_2));
			
      } // Sub
		
		
	 static void Prod() {
          
			float num_1 = 0;
			float num_2 = 0;
			
			Console.Write("Enter a number: ");
			num_1 = float.Parse(Console.ReadLine());
			Console.Write("Enter a number: ");
			num_2 = float.Parse(Console.ReadLine());
			
			Console.WriteLine("The product is: "+ (num_1 * num_2));
			
      } // Prod
		
	
	 static void Quo() {
          
			float num_1 = 0;
			float num_2 = 0;
			
			Console.Write("Enter a number: ");
			num_1 = float.Parse(Console.ReadLine());
			Console.Write("Enter a number: ");
			num_2 = float.Parse(Console.ReadLine());
			
			if (num_2 != 0) {
               Console.WriteLine("The quotient is: "+ (num_1 / num_2));
            }
				
			else {
                Console.WriteLine("Cannot divide by zero!\n");
				Quo();
            }
						
      } // Quo
		
		
	  static void Cont() {
          Console.Write("\nDo you want to continue? Y/N: ");
		  char op = char.Parse(Console.ReadLine());
		  
		  if (op == 'Y'|| op == 'y') {
              Console.WriteLine("\n");
			  Console.Clear();
              SubMenu();
          }
			 
		  else {
              return;
          }
      }
    
} // Program
