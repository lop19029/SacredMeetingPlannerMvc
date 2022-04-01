using System;
using System.Collections.Generic;

namespace SacredMeetingPlannerMvc.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string IsLeader { get; set; }
        public string Subject { get; set; }
    }
}