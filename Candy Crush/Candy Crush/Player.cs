using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    class Player
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }
        public int Games { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string UniqeCode { get; set; }
        public Player()
        {

        }
        public Player(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public static bool PlayerFinder(string username)
        {
            DataBase dataBase = new DataBase();
            foreach (var player in dataBase.players.ToList())
            {
                if(username == player.Username)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool PlayerFinder(string username, string password)
        {
            DataBase dataBase = new DataBase();
            foreach (var player in dataBase.players.ToList())
            {
                if (username == player.Username && password == player.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public static int ReturnPlayerId(string username)
        {
            DataBase dataBase = new DataBase();
            foreach (var player in dataBase.players.ToList())
            {
                if (username == player.Username)
                {
                    return player.Id;
                }
            }
            return 0;
        }
    }
}
