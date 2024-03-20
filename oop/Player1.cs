using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Player1 : Player
    {
        public Player1(string playerName, int playerAge, string faveHeroName) : base(playerName, playerAge, faveHeroName) { }
        // Overring Status from Player
        public override void Status()
        {
            Console.WriteLine("Status: " + onlineStatus);
        }
        // Overring Do from Player 
        public override void Do()
        {
            Console.WriteLine("Player 1 is " + inQueue);
        }
    }
}
