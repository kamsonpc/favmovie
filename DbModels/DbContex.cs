using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace favmovie.DbModels
{
    public class DatabaseContex : DbContext 
    {
        public DatabaseContex(DbContextOptions<DatabaseContex> options)
                :base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
              modelBuilder.Entity<MovieActor>().HasKey(ma => new { ma.MovieId,ma.ActorId });

              modelBuilder.Entity<MovieActor>()
                .HasOne<Movie>(ma => ma.Movie)
                .WithMany(m => m.MovieActor)
                .HasForeignKey(ma => ma.MovieId);


            modelBuilder.Entity<MovieActor>()
                .HasOne<Actor>(ma => ma.Actor)
                .WithMany(a => a.MovieActor)
                .HasForeignKey(ma => ma.ActorId);
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<MovieActor> MovieActor { get; set; }



    }

}
