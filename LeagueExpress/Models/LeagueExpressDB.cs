using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LeagueExpress.Models
{
    public class LeagueExpressDB :DbContext
    {

        public LeagueExpressDB() : base("name=LeagueExpressContext")
        {
        }

        public DbSet <Player> Players { get; set; }
   


    }
}