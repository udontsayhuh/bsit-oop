using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Assignment_1
{
    internal class Player2 : Player
    {
        // Player 2 Constructor
        public Player2(int playerNumber, string playerName, string typeOfPlayer, string gender, int playerAge, string heroName, double winRate) : base(playerNumber, playerName, typeOfPlayer, gender, playerAge, heroName, winRate) { }

        // Overriding Status from Player
        public override void Status()
        {
            Console.WriteLine("Status: " + onlineStatus);
        }
        // Overriding Do from Player 
        public override void Do()
        {
            Console.WriteLine("This player is " + inQueue);
        }
    }
}
