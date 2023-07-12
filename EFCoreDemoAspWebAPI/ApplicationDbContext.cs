using Microsoft.EntityFrameworkCore;

namespace EFCoreDemoAspWebAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().Property(p => p.Name)
                .HasMaxLength(250)
                .IsRequired();

            modelBuilder.Entity<Actor>().Property(p => p.Name).HasMaxLength(150).IsRequired();

            // modelBuilder.Entity<Actor>().Property(p => p.Dob).HasColumnType("Date");

            modelBuilder.Entity<Cinema>().Property(p => p.Name).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Cinema>().Property(p => p.Price).HasPrecision(precision: 9, scale: 3);

            modelBuilder.Entity<Movie>().Property(p => p.PosterURL).HasMaxLength(150).IsUnicode(false);
        }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Cinema> Cines { get; set; }

        public DbSet<Movie> Movies { get; set; }
    }
}
