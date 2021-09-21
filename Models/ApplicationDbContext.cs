using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .Property(g => g.Id)
                .ValueGeneratedOnAdd();
                

            modelBuilder.Entity<Genre>()
                .Property(g => g.Name)
                .IsRequired().HasMaxLength(100);

            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired().HasMaxLength(500);

            modelBuilder.Entity<Movie>()
                .Property(m => m.StoreLine)
                .IsRequired().HasMaxLength(3000);


            modelBuilder.Entity<Movie>()
                .Property(m => m.Poster)
                .IsRequired();

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
