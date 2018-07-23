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

        [Display(Name = "Team Size")]
        public int teamSize { get; set; }

    }
}