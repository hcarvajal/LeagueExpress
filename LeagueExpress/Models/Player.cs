using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace LeagueExpress.Models
{
    public class Player
    {
        // default changes on create

        public Player()
        {
            playerStatus = "pending";
            hasPayed = 0;
        }

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
        public string playerName
        {
            get
            {
                return playerFirstName + " " + playerLastName;
            }
        }

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

        [Required(AllowEmptyStrings=false)]
        [StringLength(200)]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "VARCHAR")]
        [Display(Name = "Team of Preference")]
        public string currentTeam { get; set; }

        [StringLength(200)]
        [Display(Name = "Shirt Size")]
        public string playerShirtSize { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Phone Number")]
        public string playerPhoneNumber { get; set; }

        [StringLength(200)]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Addres")]
        public string playerEmail { get; set; }

        [StringLength(200)]
        [Display(Name = "Status")]
        public string playerStatus { get; set; }

        [Display(Name = "Has Payed")]
        public int hasPayed { get; set; }

        [Display(Name = "Is Captain")]
        public int? isCaptain { get; set; }

        [StringLength(30)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

    }


    public enum HasPlayer
    {
        Yes,
        No
    }
}