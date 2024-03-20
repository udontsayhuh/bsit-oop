using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal abstract class Player
    {
        //Player Information
        //Private
        private string playerName, favHeroName, gender;
        private int playerAge;
        private double winRate;

        //Abstract
        public abstract void Status();
        public abstract void Do();

        //Public 
        public string onlineStatus = "Online";
        public string offlineStatus = "Offline";
        public string inGame = "In Game";
        public string inQueue = "In Queue";

        //Getters and Setters 

        // Player Name
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        //Gender
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        //Player Age
        public int PlayerAge
        {
            get { return playerAge; }
            set { playerAge = value; }
        }

        // Favorite Hero
        public string FaveHeroName
        {
            get { return favHeroName; }
            set { favHeroName = value; }
        }

        // Winrate
        public double WinRate
        {
            get { return winRate; }
            set { winRate = value; }
        }
        
        // Player Class Constructor
        public Player(string playerName, string gender, int playerAge, string favHeroName, double winRate)
        {
            PlayerName = playerName;
            PlayerAge = playerAge;
            FaveHeroName = favHeroName;
            WinRate = winRate;
        }

        // Printing The Player Information
        public void Information()
        {
            Console.WriteLine("Player 1: " + playerName);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Age: " + playerAge);
            Console.WriteLine("Favorite Hero: " + favHeroName);
            Console.WriteLine("Favorite Hero Winrate: " + winRate);
            Console.WriteLine(" ");
        }
    }
}
