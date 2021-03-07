using Microsoft.EntityFrameworkCore;

namespace Blazor.DoctorsOffice.Database
{
    public class DatabaseContext : DbContext
    {
        #region Public Constructors

        public DatabaseContext()
        {
        }

        #endregion Public Constructors

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        #endregion Protected Methods
    }
}