using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.coding_challenges
{
    internal class Challenge5
    {
        public void CarBrands()
        {
            ArrayList car = new ArrayList();
            car.Add("Mercedes-Benz");
            car.Add("Tesla");
            car.Add("BMW");
            car.Add("Ford");
            car.Add("Honda");

            car.Sort();

            foreach (var brand in car)
            {
                Console.WriteLine(brand);
            }

            Console.WriteLine(" ");
        } 
    }
}
