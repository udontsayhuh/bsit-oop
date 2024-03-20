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
        public Player1(int playerNumber, string playerName, string typeOfPlayer, string gender, int playerAge, string faveHeroName, double winRate) : base(playerNumber, playerName, typeOfPlayer, gender, playerAge, faveHeroName, winRate) { }
        // Overriding Status from Player
        public override void Status()
        {
            Console.WriteLine("Status: " + onlineStatus);
        }
        // Overriding Do from Player 
        public override void Do()
        {
            Console.WriteLine("This player is " + inGame);
        }
    }
}
