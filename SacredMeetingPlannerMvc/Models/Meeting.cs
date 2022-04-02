using System;
using System.Collections.Generic;

namespace SacredMeetingPlannerMvc.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Person Leader { get; set; }
        public int OpeningSong { get; set; }
        public int SacramentSong { get; set; }
        public string IntermediateSong { get; set; } //set to string to allow for a nullable property. Ints cannot be null -Harrison
        public int ClosingSong { get; set; }
        public List<Person> Speakers { get; set; }

    }
}