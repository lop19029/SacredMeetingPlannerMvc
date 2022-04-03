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
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Leader")]
        public bool IsLeader { get; set; }
        [Required]
        public string Subject { get; set; }
  

    }
}