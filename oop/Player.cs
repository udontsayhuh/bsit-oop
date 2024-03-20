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
        private string playerName, favHeroName;
        private int playerAge;
        private float winRate;

        //Abstract
        public abstract void Status();
        public abstract void Do();

        //Public 
        public string onlineStatus = "Online";
        public string offlineStatus = "Offline";
        public string inGame = "In Game";
        public string inQueue = "In Queue";

        //Getters and Setters 
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int PlayerAge
        {
            get { return playerAge; }
            set { playerAge = value; }
        }
        public string FaveHeroName
        {
            get { return favHeroName; }
            set { favHeroName = value; }
        }
        public float WinRate
        {
            get { return winRate; }
            set { winRate = value; }
        }

        // Player Class Constructor
        public Player(string playerName, int playerAge, string heroName)
        {
            PlayerName = playerName;
            PlayerAge = playerAge;
            FaveHeroName = heroName;
        }
        public void Information()
        {
            Console.WriteLine("Player 1: " + playerName);
            Console.WriteLine("Age: " + playerAge);
            Console.WriteLine("Favorite Hero: " + favHeroName);
            Console.WriteLine("Favorite Hero Winrate: " + winRate);
        }
    }
}
