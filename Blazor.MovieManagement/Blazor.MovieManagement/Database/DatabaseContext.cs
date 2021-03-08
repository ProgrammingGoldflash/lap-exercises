using Microsoft.EntityFrameworkCore;

namespace Blazor.MovieManagement.Database
{
    public class DatabaseContext : DbContext
    {
        #region Public Constructors

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        #endregion Public Constructors

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // === Seed Data === 

            // modelBuilder.Entity<ModelClass>().HasData(new ModelClass { Id = 1, ....... }, ...);
        }

        #endregion Protected Methods
    }
}