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
        private string playerName,typeOfPlayer, favHeroName, gender;
        private int playerAge, playerNumber;
        private double winRate;

        //Abstract
        public abstract void Status();
        public abstract void Do();

        //Public 
        public string onlineStatus = "Online";
        public string offlineStatus = "Offline";
        public string inGame = "In Game";
        public string inQueue = "In Queue";
        public string notOnline = "Not Online";

        // Getters and Setters 
        // Player Number
        public int PlayerNumber
        {
            get { return playerNumber; }
            set { playerNumber = value; }
        }
        // Player Name
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        // Type of Player
        public string TypeOfPlayer
        {
            get { return typeOfPlayer; }
            set { typeOfPlayer = value; }
        }

        // Gender
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        // Player Age
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
        public Player(int playerNumber, string playerName, string typeOfPlayer, string gender, int playerAge, string favHeroName, double winRate)
        {
            PlayerNumber = playerNumber;
            PlayerName = playerName;
            Gender = gender;
            PlayerAge = playerAge;
            FaveHeroName = favHeroName;
            WinRate = winRate;
            TypeOfPlayer = typeOfPlayer;
        }

        // Printing The Normal Player Information
        public void normalPlayerInformation()
        {
            Console.WriteLine("Player " + playerNumber + ": " + playerName);
            Console.WriteLine("Type of Player: " + typeOfPlayer);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Age: " + playerAge);
            Console.WriteLine("Favorite Hero: " + favHeroName);
            Console.WriteLine("Favorite Hero Winrate: " + winRate);
        }

    }
}
