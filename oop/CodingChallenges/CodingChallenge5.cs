using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.CodingChallenges
{
    internal class CodingChallenge5
    {
        public void Vehicle()
        {
            ArrayList vehicle = new ArrayList();
            vehicle.Add("Toyota");
            vehicle.Add("Volvo");
            vehicle.Add("Ford");
            vehicle.Add("Honda");
            vehicle.Add("Mitsubishi");
            Console.Write($"The Cars are: ");
            foreach (var i in vehicle)
            {
                Console.Write(i + " ");
            }
        }
        
    }
}
