using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeagueExpress.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public int hasPayed { get; set; }
        public string currentTeam { get; set; }
        public string playerStatus { get; set; }
        public int isCaptain { get; set; }
    }
}