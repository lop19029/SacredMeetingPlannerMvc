using SacredMeetingPlannerMvc.Models;
using System;
using System.Linq;

namespace SacredMeetingPlannerMvc.Data
{
    public class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            // sets the Date library
            var getCurrentDate = DateTime.Now;

            context.Database.EnsureCreated();

            //look for any people
            if (context.Person.Any())
            {
                return; //DB was seeded
            }

            var persons = new Person[]
            {
                new Person{ID=1, LastName="Crews", FirstName="Terry", IsLeader=true, Subject="Holy Ghost"},
                new Person{ID=2, LastName="Cruise", FirstName="Tom", IsLeader=false, Subject="Revelation"},
                new Person{ID=3, LastName="Hanks", FirstName="Tom", IsLeader=true, Subject="Book of Mormon"},
                new Person{ID=4, LastName="Trejo", FirstName="Danny", IsLeader=false, Subject="Repentance"},
                new Person{ID=5, LastName="Rock", FirstName="Chris", IsLeader=true, Subject="Stand in holy places"},
            };

            foreach (Person p in persons)
            {
                context.Person.Add(p);
            }
            context.SaveChanges();

            var meetings = new Meeting[]
            {
                new Meeting{ID=1, Date=getCurrentDate.Date, Leader=persons[0], OpeningSong=44, SacramentSong=121, ClosingSong=130, Speakers={persons[2], persons[1], persons[3] } },
                new Meeting{ID=2, Date=getCurrentDate.Date, Leader=persons[4], OpeningSong=308, SacramentSong=134, ClosingSong=255, Speakers={persons[1], persons[4], persons[0] } },
                new Meeting{ID=3, Date=getCurrentDate.Date, Leader=persons[3], OpeningSong=55, SacramentSong=123, IntermediateSong="44", ClosingSong=150, Speakers={persons[2], persons[1] } },
                new Meeting{ID=4, Date=getCurrentDate.Date, Leader=persons[2], OpeningSong=121, SacramentSong=242, ClosingSong=155, Speakers={persons[4], persons[1], persons[0] } }
            };

            foreach(Meeting m in meetings)
            {
                context.Meeting.Add(m);
            }
            context.SaveChanges();
        }
    }
}
