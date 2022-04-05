using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SacredMeetingPlannerMvc.Models
{
    public class Person
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        
        [DisplayName("Leader")]
        public bool IsLeader { get; set; }

        [StringLength(100, MinimumLength = 8)]
        [Required]
        public string Subject { get; set; }
  

    }
}