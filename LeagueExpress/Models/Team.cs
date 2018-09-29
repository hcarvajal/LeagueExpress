using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeagueExpress.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(200)]
        public string teamName { get; set; }

        [Display(Name = "Manager")]
        [StringLength(200)]
        public string teamManager { get; set; }

        [Display(Name = "Size")]
        public int? teamSize { get; set; }

        [Display(Name = "Position")]
        public int? teamPosition { get; set; }

        [Display(Name = "Games Played")]
        public int? teamGamesPlayed { get; set; }

        [Display(Name = "Total Points")]
        public int? teamPoints { get; set; }

        [Display(Name = "Is Active")]
        public int? teamActive { get; set; }


    }
}