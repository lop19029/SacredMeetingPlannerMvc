using SacredMeetingPlannerMvc.Models;
using System;
using System.Linq;

namespace SacredMeetingPlannerMvc.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();
            
            // sets the Date library
            var getCurrentDate = DateTime.Now;


            //look for any people
            if (context.Person.Any())
            {
                return; //DB was seeded
            }

            var persons = new Person[]
            {
                new Person{LastName="Crews", FirstName="Terry", IsLeader=true, Subject="Holy Ghost"},
                new Person{LastName="Cruise", FirstName="Tom", IsLeader=false, Subject="Revelation"},
                new Person{LastName="Hanks", FirstName="Tom", IsLeader=true, Subject="Book of Mormon"},
                new Person{LastName="Trejo", FirstName="Danny", IsLeader=false, Subject="Repentance"},
                new Person{LastName="Rock", FirstName="Chris", IsLeader=true, Subject="Stand in holy places"}
            };

            foreach (Person p in persons)
            {
                context.Person.Add(p);
            }
            context.SaveChanges();

            if (context.Meeting.Any())
            {
                return;
            }

            var meetings = new Meeting[]
            {
                new Meeting{Date=getCurrentDate.Date, Leader=persons[0], OpeningSong=44, SacramentSong=121, ClosingSong=130 },
                new Meeting{Date=getCurrentDate.Date, Leader=persons[4], OpeningSong=308, SacramentSong=134, ClosingSong=25 },
                new Meeting{Date=getCurrentDate.Date, Leader=persons[3], OpeningSong=55, SacramentSong=123, IntermediateSong="44", ClosingSong=150 },
                new Meeting{Date=getCurrentDate.Date, Leader=persons[2], OpeningSong=121, SacramentSong=242, ClosingSong=155 }
            };

            foreach(Meeting m in meetings)
            {
                context.Meeting.Add(m);
            }
            context.SaveChanges();
        }
    }
}
