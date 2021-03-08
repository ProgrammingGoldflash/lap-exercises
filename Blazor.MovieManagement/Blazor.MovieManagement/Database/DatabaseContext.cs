using Blazor.MovieManagement.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blazor.MovieManagement.Database
{
    public class DatabaseContext : DbContext
    {
        #region Public Constructors

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ProductionCompany> ProductionCompanies { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>().HasKey(u => new
            {
                u.ActorId,
                u.MovieId
            });

            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FirstName = "Leonardo", LastName = "DiCaprio", CountryOfOrigin = "USA" },
                new Actor { Id = 2, FirstName = "Kyle", LastName = "Chandler", CountryOfOrigin = "USA" },
                new Actor { Id = 3, FirstName = "Sandra ", LastName = "Bullock", CountryOfOrigin = "USA" },
                new Actor { Id = 4, FirstName = "Steve ", LastName = "Carell", CountryOfOrigin = "USA" }
            );

            modelBuilder.Entity<ProductionCompany>().HasData(
                new ProductionCompany { Id = 1, Name = "Warner Bros" },
                new ProductionCompany { Id = 2, Name = "Walt Disney Studios" },
                new ProductionCompany { Id = 3, Name = "Universal Pictures" },
                new ProductionCompany { Id = 4, Name = "Paramount Pictures" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Godzilla vs. Kong", ReleaseDate = new DateTime(2021, 03, 25), ProductionCompanyId = 1 },
                new Movie { Id = 2, Title = "Disney's American Legends", ReleaseDate = new DateTime(2001, 02, 11), ProductionCompanyId = 2 },
                new Movie { Id = 3, Title = "Minions", ReleaseDate = new DateTime(2015, 06, 03), ProductionCompanyId = 3 },
                new Movie { Id = 4, Title = "Transformers", ReleaseDate = new DateTime(2007, 07, 12), ProductionCompanyId = 4 },
                new Movie { Id = 5, Title = "Titanic", ReleaseDate = new DateTime(1998, 01, 09), ProductionCompanyId = 4 }
            );

            modelBuilder.Entity<MovieActor>().HasData(
                new MovieActor { MovieId = 1, ActorId = 2 },
                new MovieActor { MovieId = 3, ActorId = 3 },
                new MovieActor { MovieId = 3, ActorId = 4 },
                new MovieActor { MovieId = 5, ActorId = 1 }
            );
        }

        #endregion Protected Methods
    }
}