using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Player3 : Player
    {
        public Player3(int playerNumber, string playerName, string gender, int playerAge, string favHeroName, double winRate) : base (playerNumber, playerName, gender, playerAge, favHeroName, winRate) { }

        public override void Do()
        {
            Console.WriteLine("This player is " + notOnline);
        }

        public override void Status()
        {
            Console.WriteLine("Status: " + offlineStatus);      
        }
    }
}
