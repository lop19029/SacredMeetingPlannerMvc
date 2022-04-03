using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SacredMeetingPlannerMvc.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Person Leader { get; set; }
        [Required]
        [DisplayName("Opening Hymn")]
        public int OpeningSong { get; set; }
        [Required]
        [DisplayName("Sacrament Hymn")]
        public int SacramentSong { get; set; }
        [DisplayName("Intermediate Hymn")]
        public string IntermediateSong { get; set; } //set to string to allow for a nullable property. Ints cannot be null -Harrison
        [Required]
        [DisplayName("Closing Hymn")]
        public int ClosingSong { get; set; }
        public List<Person> Speakers { get; set; }

    }
}