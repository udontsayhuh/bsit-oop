using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Player3 : Player
    {
        public string typeOfPlayer { get; set; }
        public int noOfChampionship { get; set; }
        public Player3(int playerNumber, string playerName, string typeOfPlayer, int noOfChampionship, string gender, int playerAge, string favHeroName, double winRate) : base (playerNumber, playerName, typeOfPlayer, gender, playerAge, favHeroName, winRate) 
        {
            this.typeOfPlayer = typeOfPlayer;
            this.noOfChampionship = noOfChampionship;
        }

        public override void Do()
        {
            Console.WriteLine("This player is " + notOnline);
        }

        public override void Status()
        {
            Console.WriteLine("Status: " + offlineStatus);      
        }
        public void professionalPlayerInformation()
        {
            Console.WriteLine("Player " + PlayerNumber + ": " + PlayerName);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Type of Player: " + typeOfPlayer);
            Console.WriteLine("No. of Championship Won: " + noOfChampionship);
            Console.WriteLine("Age: " + PlayerAge);
            Console.WriteLine("Favorite Hero: " + FaveHeroName);
            Console.WriteLine("Favorite Hero Winrate: " + WinRate);
        }
    }
}
