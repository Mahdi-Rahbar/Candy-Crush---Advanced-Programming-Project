using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Candy_Crush
{
    class DataBase : DbContext
    {
        public DataBase() : base("name=ccdbs")
        {

        }
        public DbSet<Player> players { get; set; }
    }
}
