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

        [Required]
        [StringLength(200)]
        public string playerLastName { get; set; }

        
        [StringLength(200)]
        public string playerMiddileName { get; set; }

        [Required]
        [Display(Name = "Has Played")]
        public int playerHasPlayed { get; set; }

        [Required]
        [Display(Name ="Age")]
        public int playerAge { get; set;}

        [StringLength(200)]
        [Display(Name = "Height")]
        public string playerHeight { get; set; }

        [StringLength(200)]
        [Display(Name = "Place of Birth")]
        public string playerPlaceOfBirth { get; set; }

        [StringLength(200)]
        [Display(Name = "Player")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string playerName { get; set; }

        [Display(Name = "Player Number")]
        public int playerNumber { get; set; }

        [StringLength(200)]
        [Display(Name = "Position Preferred")]
        public string playerPosition { get; set; }


        [Display(Name = "Player Ranking")]
        [Range(1, 10)]
        public int playerRanking { get; set; } = 1;

        [Display(Name = "Player Apps")]
        public int playerApps { get; set; }

        [Display(Name = "Team of Preference")]
        public int currentTeam { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Phone Number")]
        public string playerPhoneNumber { get; set; }

        [StringLength(200)]
        [Display(Name = "Phone Email")]
        public string playerEmail { get; set; }

    }


    public enum HasPlayer
    {
        Yes,
        No
    }
}