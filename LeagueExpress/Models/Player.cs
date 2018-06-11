using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LeagueExpress.Models
{
    public class Player
    {

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string playerFirstName { get; set; }
        public string playerLastName { get; set; }
        public string playerMiddileName { get; set; }
        public int playerHasPlayed { get; set; }
        public DateTime playerDOB { get; set; }
        public string playerHeight { get; set; }
        public string playerPlaceOfBirth { get; set; }
        [Display(Name = "Player")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string playerName { get; set; }
        public int playerNumber { get; set; }
        public int playerPosition { get; set; }

        [Range(1, 10)]
        public int playerRanking { get; set; }
        public int playerApps { get; set; }
        public int currentTeam { get; set; }

    }
}