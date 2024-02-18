using Microsoft.EntityFrameworkCore;
using Proiect_MPA_Batinas_Iulia.Models;

namespace Proiect_MPA_Batinas_Iulia.Data
{
    public class CinemaContext:DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) :
base(options)
        {
        }
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieSchedule> MovieSchedules{ get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auditorium>().ToTable("Auditorium");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<MovieSchedule>().ToTable("MovieSchedule");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
        }


    }
}
