using Microsoft.EntityFrameworkCore;
using MovieManagement.Entities;

namespace MovieManagement.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = default!;

        public DbSet<Actor> Actors { get; set; } = default!;

        public DbSet<Genre> Genres { get; set; } = default!;

        public DbSet<Biography> Biographies { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Genres)
                .WithMany(g => g.Movies)
                .UsingEntity(j => j.ToTable("MovieGenres"));

            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Actor)
                .WithMany(a => a.Movies)
                .UsingEntity(j => j.ToTable("MovieActors"));

            modelBuilder.Entity<Actor>()
                .HasOne(a => a.Biography)
                .WithOne(b => b.Actor)
                .HasForeignKey<Biography>(b => b.ActorId);
        }


    }
}
