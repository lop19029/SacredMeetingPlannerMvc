using System;
using System.Collections.Generic;

namespace SacredMeetingPlannerMvc.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Leader Leader { get; set; }
        public int OpeningSong { get; set; }
        public int SacramentSong { get; set; }
        public int IntermediateSong { get; set; } //optional
        public int ClosingSong { get; set; }
        public List<Speaker> Speakers { get; set; }

    }
}