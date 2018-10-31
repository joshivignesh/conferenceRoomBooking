using conferenceroombooking.Entities;
using Microsoft.EntityFrameworkCore;

namespace conferenceroombooking.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=conferenceDb;Trusted_Connection=True;");
        //}

    }
}
