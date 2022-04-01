using System;
using System.Collections.Generic;

namespace SacredMeetingPlannerMvc.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
       
    }
}