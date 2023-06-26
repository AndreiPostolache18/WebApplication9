using Microsoft.EntityFrameworkCore;

namespace WebApplication9.Models
{
    public class App9Context : DbContext
    {
        public App9Context(DbContextOptions<App9Context> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Desk> Desks { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=App9DeskSharing;Trusted_Connection=True;TrustServerCertificate=true");


        }
    }
}
