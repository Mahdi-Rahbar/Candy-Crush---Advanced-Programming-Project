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
        public Player()
        {

        }
        public Player(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
