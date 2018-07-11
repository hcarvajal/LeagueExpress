using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LeagueExpress.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Reason { get; set; }

        [Required]
        [StringLength(200)]
        public string Message { get; set; }
    }
}