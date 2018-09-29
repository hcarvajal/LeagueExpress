using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LeagueExpress.Models
{
    public class MatchSchedule
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Match Week")]
        public int matchWeek { get; set; }

        [Display(Name = "Match Date")]
        public string matchDate { get; set; }

        [Display(Name = "Match Time")]
        [StringLength(200)]
        public string matchTime { get; set; }

        [Display(Name = "Home Team")]
        [StringLength(200)]
        public string matchHomeTeam { get; set; }

        [Display(Name = "Away Team")]
        [StringLength(200)]
        public string matchAwayTeam { get; set; }

        [Display(Name = "Home Team Result")]
        [StringLength(200)]
        public string matchHomeResult { get; set; }

        [Display(Name = "Away Team Result")]
        [StringLength(200)]
        public string matchAwayResult { get; set; }

        [Display(Name = "Match Status")]
        [StringLength(200)]
        public string matchStatus { get; set; }


    }
}