using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeagueExpress.Models
{
    public class Fixtures
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime fixtureDate { get; set; }

        [Required]
        [Display(Name = "Time")]
        public DateTime fixtureTime { get; set; }

        [Required]
        [Display(Name = "Home Team")]
        public int fixtureHomeTeam { get; set; }

        [Required]
        [Display(Name = "Away Team")]
        public int fixtureAwayTeam { get; set; }
    }
}