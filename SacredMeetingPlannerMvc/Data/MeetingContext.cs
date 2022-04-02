using SacredMeetingPlannerMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SacredMeetingPlannerMvc.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Meeting> Meeting { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}