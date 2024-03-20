using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Player1 : Player
    {
        public Player1(int playerNumber, string playerName, string gender, int playerAge, string faveHeroName, double winRate) : base(playerNumber,playerName, gender, playerAge, faveHeroName, winRate) { }
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
